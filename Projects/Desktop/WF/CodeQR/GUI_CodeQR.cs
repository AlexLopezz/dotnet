using System.Drawing.Imaging;
using QRCoder;
namespace CodeQR
{
    public partial class GUI_CodeQR : Form
    {
        #region VARIABLES
        SaveFileDialog? saveFileDialog;
        #endregion
        public GUI_CodeQR()
        {
            InitializeComponent();
            LoadFileDialog();
        }
        #region UTILS
        /// <summary>
        /// Este metodo es el encargado de verificar si el campo contiene 
        /// texto o no, para ser generado a QR
        /// </summary>
        /// <returns>true - false, si retorna false mostrara un error de tipo ErrorProvider</returns>
        private bool CheckField()
        {
            if (!string.IsNullOrEmpty(txtQR.Text))
            {
                error.Clear();
                return true;
            }
            else
            {
                error.SetError(
                    txtQR,
                    "Your QR must have a URL!"
                );
                return false;
            }
        }
        /// <summary>
        /// Este metodo inicializara el cuadro de dialogo encargado para 
        /// guardar el QR generado.
        /// </summary>
        private void LoadFileDialog()
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.Filter = "Only Image PNG(*.png)|*.png";
        }
        #endregion
        #region EVENTS
        /// <summary>
        /// Este evento generara un QR con la URL adjunta que introdujo el usuario.
        /// </summary>
        private void PressGenerate(object sender, EventArgs e)
        {
            if (CheckField())
            {
                var QRGenerator = new QRCodeGenerator();
                QRCodeData dataQR = QRGenerator.CreateQrCode(
                    txtQR.Text,
                    QRCodeGenerator.ECCLevel.Q);

                QRCode qrCode = new QRCode(dataQR);
                picQR.Image = qrCode.GetGraphic(5);
            }
        }
        /// <summary>
        /// Este evento guardara el QR generado en formato .png
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PressSave(object sender, EventArgs e)
        {
            if (CheckField())
            {
                Image imgSave = (Image)picQR.Image.Clone();
                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK &&
                    !string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    string PATH = saveFileDialog.FileName;
                    imgSave.Save(PATH, ImageFormat.Png);
                    MessageBox.Show(
                        "Your QR save correctly!",
                        "Succes!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                imgSave.Dispose();
            }
        }
        #endregion
    }
}
