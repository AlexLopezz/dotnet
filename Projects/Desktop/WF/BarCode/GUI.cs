using BarcodeLib;
using System.Drawing.Imaging;

namespace BarCode
{
    public partial class GUI : Form
    {
        #region VARIABLES
        SaveFileDialog? saveFileDialog;
        #endregion
        
        public GUI()
        {
            InitializeComponent();
            LoadFileDialog();
        }

        #region EVENTS
        /// <summary>
        /// Este metodo verificara si el campo de texto del codigo de barras esta vacio o no.
        /// </summary>
        /// <returns>true - false, en caso de false lanzara un error de tipo ErrorProvider.</returns>
        private bool CheckField()
        {
            if (!string.IsNullOrEmpty(txtCodeBar.Text))
            {
                error.Clear();
                return true;
            }
            else
            {
                error.SetError(
                    txtCodeBar,
                    "Your barcode must have a name!"
                );
                return false;
            }
        }
        /// <summary>
        /// Este metodo se encarga de inicializar con valores predeterminados
        /// el cuadro de dialogo para guardar la imagen generada.
        /// </summary>
        private void LoadFileDialog()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Filter = "Only Image PNG(*.png)|*.png";
        }
        /// <summary>
        /// Este es un evento que se lanzara cuando demos click al boton "Generate"
        /// Basicamente generara un codigo de barras con el texto introducido por el usuario.
        /// </summary>
        private void PressGenerate(object sender, EventArgs e)
        {
            if (CheckField())
            {
                error.SetError(txtCodeBar, string.Empty);
                Barcode code = new Barcode();
                code.IncludeLabel = true;

                Image imageBarCode = code.Encode(
                    TYPE.CODE128,
                    txtCodeBar.Text,
                    Color.Black,
                    Color.White);

                picBarCode.Image = imageBarCode;
                bttSave.Enabled = true;
            }
        }
        /// <summary>
        /// Este evento se lanzara cuando demos Click al boton "Save"
        /// Guardara en imagen, el codigo de barras generado.
        /// </summary>
        private void PressSave(object sender, EventArgs e)
        {
            if (CheckField())
            {
                Image imgSave = (Image)picBarCode.Image.Clone();
                DialogResult result = saveFileDialog.ShowDialog();

                if ( result == DialogResult.OK &&
                    !string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    string PATH = saveFileDialog.FileName;
                    imgSave.Save(PATH, ImageFormat.Png);
                    MessageBox.Show(
                        "Code bar save correctly!",
                        "Succes!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                imgSave.Dispose();
            }
            else bttSave.Enabled = false;
        }
        #endregion
    }
}