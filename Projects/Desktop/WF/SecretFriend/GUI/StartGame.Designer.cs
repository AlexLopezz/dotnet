namespace SecretFriend.GUI
{
    partial class StartGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartGame));
            panelStartGame = new Panel();
            lblTitle = new Label();
            bttStart = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panelStartGame.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelStartGame
            // 
            panelStartGame.BackColor = Color.FromArgb(255, 192, 128);
            panelStartGame.Controls.Add(lblTitle);
            panelStartGame.Controls.Add(bttStart);
            panelStartGame.Controls.Add(panel2);
            panelStartGame.Dock = DockStyle.Fill;
            panelStartGame.Location = new Point(0, 0);
            panelStartGame.Name = "panelStartGame";
            panelStartGame.Size = new Size(584, 361);
            panelStartGame.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(168, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "¡AMIGO INVISIBLE!";
            // 
            // bttStart
            // 
            bttStart.BackColor = Color.FromArgb(128, 255, 128);
            bttStart.FlatStyle = FlatStyle.Popup;
            bttStart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttStart.Location = new Point(208, 242);
            bttStart.Name = "bttStart";
            bttStart.Size = new Size(184, 83);
            bttStart.TabIndex = 1;
            bttStart.Text = "¡EMPEZAR!";
            bttStart.UseVisualStyleBackColor = false;
            bttStart.Click += PressStartGame;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(120, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 184);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.amigo_invisible_background;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // StartGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(panelStartGame);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home - Secret Friend";
            panelStartGame.ResumeLayout(false);
            panelStartGame.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelStartGame;
        private Panel panel2;
        private Button bttStart;
        private PictureBox pictureBox1;
        private Label lblTitle;
    }
}