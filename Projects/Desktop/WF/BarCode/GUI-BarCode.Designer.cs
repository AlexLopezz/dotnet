namespace BarCode
{
    partial class GUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            bttCodeBar = new Button();
            bttSave = new Button();
            panelCodeBar = new Panel();
            picBarCode = new PictureBox();
            txtCodeBar = new TextBox();
            lblTextCodeBar = new Label();
            error = new ErrorProvider(components);
            panelCodeBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBarCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error).BeginInit();
            SuspendLayout();
            // 
            // bttCodeBar
            // 
            bttCodeBar.Location = new Point(130, 256);
            bttCodeBar.Name = "bttCodeBar";
            bttCodeBar.Size = new Size(118, 23);
            bttCodeBar.TabIndex = 0;
            bttCodeBar.Text = "Generate";
            bttCodeBar.UseVisualStyleBackColor = true;
            bttCodeBar.Click += PressGenerate;
            // 
            // bttSave
            // 
            bttSave.Enabled = false;
            bttSave.Location = new Point(149, 285);
            bttSave.Name = "bttSave";
            bttSave.Size = new Size(75, 23);
            bttSave.TabIndex = 1;
            bttSave.Text = "Save";
            bttSave.UseVisualStyleBackColor = true;
            bttSave.Click += PressSave;
            // 
            // panelCodeBar
            // 
            panelCodeBar.BackColor = SystemColors.ControlDark;
            panelCodeBar.Controls.Add(picBarCode);
            panelCodeBar.Location = new Point(12, 12);
            panelCodeBar.Name = "panelCodeBar";
            panelCodeBar.Size = new Size(360, 194);
            panelCodeBar.TabIndex = 2;
            // 
            // picBarCode
            // 
            picBarCode.Dock = DockStyle.Fill;
            picBarCode.Location = new Point(0, 0);
            picBarCode.Name = "picBarCode";
            picBarCode.Size = new Size(360, 194);
            picBarCode.TabIndex = 0;
            picBarCode.TabStop = false;
            // 
            // txtCodeBar
            // 
            txtCodeBar.Location = new Point(12, 227);
            txtCodeBar.Name = "txtCodeBar";
            txtCodeBar.Size = new Size(315, 23);
            txtCodeBar.TabIndex = 3;
            // 
            // lblTextCodeBar
            // 
            lblTextCodeBar.AutoSize = true;
            lblTextCodeBar.Location = new Point(12, 209);
            lblTextCodeBar.Name = "lblTextCodeBar";
            lblTextCodeBar.Size = new Size(117, 15);
            lblTextCodeBar.TabIndex = 4;
            lblTextCodeBar.Text = "Text from Code bar...";
            // 
            // error
            // 
            error.ContainerControl = this;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 311);
            Controls.Add(lblTextCodeBar);
            Controls.Add(txtCodeBar);
            Controls.Add(panelCodeBar);
            Controls.Add(bttSave);
            Controls.Add(bttCodeBar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Code Bar by Alex Lopez!";
            panelCodeBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBarCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttCodeBar;
        private Button bttSave;
        private Panel panelCodeBar;
        private TextBox txtCodeBar;
        private Label lblTextCodeBar;
        private PictureBox picBarCode;
        private ErrorProvider error;
    }
}