namespace CodeQR
{
    partial class GUI_CodeQR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelQR = new Panel();
            picQR = new PictureBox();
            bttSave = new Button();
            bttGenerate = new Button();
            lblQR = new Label();
            txtQR = new TextBox();
            error = new ErrorProvider(components);
            panelQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            SuspendLayout();
            // 
            // panelQR
            // 
            panelQR.BackColor = SystemColors.ControlDark;
            panelQR.Controls.Add(picQR);
            panelQR.Location = new Point(18, 12);
            panelQR.Name = "panelQR";
            panelQR.Size = new Size(357, 200);
            panelQR.TabIndex = 0;
            // 
            // picQR
            // 
            picQR.Dock = DockStyle.Fill;
            picQR.Location = new Point(0, 0);
            picQR.Name = "picQR";
            picQR.Size = new Size(357, 200);
            picQR.SizeMode = PictureBoxSizeMode.Zoom;
            picQR.TabIndex = 0;
            picQR.TabStop = false;
            // 
            // bttSave
            // 
            bttSave.Location = new Point(154, 304);
            bttSave.Name = "bttSave";
            bttSave.Size = new Size(75, 23);
            bttSave.TabIndex = 1;
            bttSave.Text = "Save";
            bttSave.UseVisualStyleBackColor = true;
            bttSave.Click += PressSave;
            // 
            // bttGenerate
            // 
            bttGenerate.Location = new Point(119, 265);
            bttGenerate.Name = "bttGenerate";
            bttGenerate.Size = new Size(137, 33);
            bttGenerate.TabIndex = 2;
            bttGenerate.Text = "Generate";
            bttGenerate.UseVisualStyleBackColor = true;
            bttGenerate.Click += PressGenerate;
            // 
            // lblQR
            // 
            lblQR.AutoSize = true;
            lblQR.Location = new Point(155, 215);
            lblQR.Name = "lblQR";
            lblQR.Size = new Size(74, 15);
            lblQR.TabIndex = 3;
            lblQR.Text = "URL for QR...";
            // 
            // txtQR
            // 
            txtQR.ForeColor = Color.SteelBlue;
            txtQR.Location = new Point(21, 236);
            txtQR.Name = "txtQR";
            txtQR.Size = new Size(354, 23);
            txtQR.TabIndex = 4;
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // GUI_CodeQR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 331);
            Controls.Add(txtQR);
            Controls.Add(lblQR);
            Controls.Add(bttGenerate);
            Controls.Add(bttSave);
            Controls.Add(panelQR);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GUI_CodeQR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QRCode by Alex Lopez!";
            panelQR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelQR;
        private PictureBox picQR;
        private Button bttSave;
        private Button bttGenerate;
        private Label lblQR;
        private TextBox txtQR;
        private ErrorProvider error;
    }
}