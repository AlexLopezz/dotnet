using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_Lorem_Ipsum
{
    public partial class GUI_CountWord : Form
    {
        #region VARIABLES
        int countWords,
            countSentences,
            countLetters,
            countParagraph;
        #endregion

        public GUI_CountWord()
        {
            InitializeComponent();
        }
        #region UTILS
        private int CountSentences(string board) => board.Split('.').Length - 1;

        private int CountParagraph(string board)
        {
            int paragraph = 0;
            var contentBoard = board.
                Replace(" ", "").Split('\r');
            int lastLetterParagraph;

            for(int i=0; i < contentBoard.Length; i++)
            {
                lastLetterParagraph = contentBoard[i].Length - 1;
                if (contentBoard[i][lastLetterParagraph] == '.') paragraph++;
            }
            return paragraph;
        }

        private int CountAllWords(string board)
        {
            var cleanText = board
                .Replace(";", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace(":", "")
                .Replace("¿", "")
                .Replace("\r", "");

            var words = cleanText
                .Split(
                ' ',
                '\r',
                (char)StringSplitOptions.RemoveEmptyEntries
                );

            return words.Length;
        }

        private int CountAllLetters(string board)
        {
            int letters = 0;
            foreach(var b in board)
            {
                if (char.IsLetter(b)) letters++; 
            }

            return letters;
        }
        #endregion

        #region EVENTS
        /// <summary>
        /// Este evento se accionara cuando clickamos en el boton 'Check'
        /// lo cual, calculara la cantidad de parrafos, oraciones, letras y palabras
        /// del texto insertado y mostrara en el costado izquierdo de la interfaz.
        /// </summary>
        private void PressCheck(object sender, EventArgs e)
        {
            if (txtBoard.Text.Length != 0)
            {
                countWords = CountAllWords(txtBoard.Text);
                countLetters = CountAllLetters(txtBoard.Text);
                countParagraph = CountParagraph(txtBoard.Text);
                countSentences = CountSentences(txtBoard.Text);

                lblCountWords.Text = countWords.ToString();
                lblCountLetters.Text = countLetters.ToString();
                lblCountParagraph.Text = countParagraph.ToString();
                lblCountSentences.Text = countSentences.ToString();
            }
        }

        #endregion

    }
}
