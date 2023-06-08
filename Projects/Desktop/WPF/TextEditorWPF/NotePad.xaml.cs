using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
        #region VARIABLES
        string? defaultStringCharacters, defaultStringWords;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        
        #endregion
        public NotePad()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadDefaultSrings();
            loadFileDialog();
        }
        #region UTILS
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
        bool IsNotePadVoid() => txtNotePad.Text.Length == 0;
        #endregion
        #region EVENTS
        /**
         * Este metodo, mostrara informacion del programa y su propio codigo fuente
         * el cual, si aprieta el boton de 'Si', redireccionara al codigo que se encuentra
         * en GitHub de mi proyecto.
         */ 
        private void mnuAbout_Click(object sender, RoutedEventArgs e)
        {
            string URLRepo = "https://github.com/AlexLopezz/DotNet/tree/main/Projects/Desktop/WPF/TextEditorWPF";
            
            MessageBoxResult result = MessageBox.Show("Este programa fue desarrollado por Alex Lopez. ¿Desea ver el codigo fuente en el repositorio de GitHub?", "Created by Alex Lopez", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {URLRepo}") { CreateNoWindow = true });
            }
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
        private void mnuClose_Click(object sender, RoutedEventArgs e)
        {
            if (!IsNotePadVoid())
            {
                MessageBoxResult result = MessageBox.Show("¿Esta seguro que desea salir, sin antes guardar?",
                                                          "Texto sin guardar.",
                                                          MessageBoxButton.YesNo,
                                                          MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes) this.Close();
            }
        }
        private void txtNotePad_KeyDown(object sender, KeyEventArgs e)
        {
            string[] words = txtNotePad.Text.Split(" ");

            stCharacters.Content = defaultStringCharacters + txtNotePad.Text.Length;
            stWords.Content = defaultStringWords + words.Length;
        }
        #endregion
    }
}
