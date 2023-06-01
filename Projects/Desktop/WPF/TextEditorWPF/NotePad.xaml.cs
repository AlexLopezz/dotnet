using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TextEditorWPF
{
    /// <summary>
    /// Interaction logic for NotePad.xaml
    /// </summary>
    public partial class NotePad : Window
    {
        #region UTILS
        string? defaultStringCharacters, defaultStringWords;
        OpenFileDialog? openFileDialog;
        SaveFileDialog? saveFileDialog;
        
        #endregion
        public NotePad()
        {
            InitializeComponent();
            loadDefaultSrings();
            loadFileDialog();

        }

        #region INIT
        void loadFileDialog()
        {
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            List<FileDialog> fileDialogs = new List<FileDialog>();
            fileDialogs.Add(openFileDialog);
            fileDialogs.Add(saveFileDialog);

            foreach(FileDialog fd in fileDialogs)
            {
                fd.FileName = "Your path text Document here...";
                fd.Filter = "Only text documents... (*.txt)|*.txt";
            }
        }
        void loadDefaultSrings()
        {
            defaultStringCharacters = (string)stCharacters.Content;
            defaultStringWords = (string)stWords.Content;
        }
        #endregion

        #region EVENTS
        private void mnuAbout_Click(object sender, RoutedEventArgs e)
        {

        }

        /**
         * Este metodo, permitira al usuario quien manipule el programa
         * a abrir un archivo de texto y mostrar por pantalla(desde el notepad)
         */ 
        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            if(openFileDialog.ShowDialog() == true)
            {
                string contentOpenFileDialog = File.ReadAllText(openFileDialog.FileName);
                txtNotePad.Text = contentOpenFileDialog;
            }
        }

        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            NotePad notePad = new NotePad();
            notePad.Show();
        }

        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {
            if(saveFileDialog.ShowDialog() == true) File.WriteAllText(saveFileDialog.FileName, txtNotePad.Text);
        }

        private void mnuClose_Click(object sender, RoutedEventArgs e) => this.Close();

        private void mnuFont_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
