namespace SimonSayWF
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            imgSimonSay = new PictureBox();
            lblVersion = new Label();
            lblFood = new Label();
            imgFood = new PictureBox();
            bttStart = new Button();
            bttExit = new Button();
            ((System.ComponentModel.ISupportInitialize)imgSimonSay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgFood).BeginInit();
            SuspendLayout();
            // 
            // imgSimonSay
            // 
            imgSimonSay.Image = (Image)resources.GetObject("imgSimonSay.Image");
            imgSimonSay.Location = new Point(150, 10);
            imgSimonSay.Name = "imgSimonSay";
            imgSimonSay.Size = new Size(274, 171);
            imgSimonSay.SizeMode = PictureBoxSizeMode.StretchImage;
            imgSimonSay.TabIndex = 0;
            imgSimonSay.TabStop = false;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.Red;
            lblVersion.Location = new Point(253, 184);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(107, 34);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "VERSION";
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.BackColor = Color.Transparent;
            lblFood.Font = new Font("Impact", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            lblFood.ForeColor = Color.Black;
            lblFood.Location = new Point(188, 184);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(71, 34);
            lblFood.TabIndex = 2;
            lblFood.Text = "FOOD";
            // 
            // imgFood
            // 
            imgFood.Image = SimonSay.Properties.Resources.plato;
            imgFood.Location = new Point(354, 184);
            imgFood.Name = "imgFood";
            imgFood.Size = new Size(45, 34);
            imgFood.SizeMode = PictureBoxSizeMode.CenterImage;
            imgFood.TabIndex = 3;
            imgFood.TabStop = false;
            // 
            // bttStart
            // 
            bttStart.BackColor = Color.FromArgb(87, 255, 53);
            bttStart.FlatAppearance.BorderColor = Color.Black;
            bttStart.FlatAppearance.BorderSize = 0;
            bttStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bttStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bttStart.FlatStyle = FlatStyle.Popup;
            bttStart.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttStart.ForeColor = Color.Black;
            bttStart.Location = new Point(202, 239);
            bttStart.Name = "bttStart";
            bttStart.Size = new Size(178, 62);
            bttStart.TabIndex = 4;
            bttStart.Text = "START";
            bttStart.UseVisualStyleBackColor = false;
            bttStart.Click += eventStart;
            // 
            // bttExit
            // 
            bttExit.BackColor = Color.FromArgb(254, 19, 0);
            bttExit.FlatStyle = FlatStyle.Popup;
            bttExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttExit.Location = new Point(253, 307);
            bttExit.Name = "bttExit";
            bttExit.Size = new Size(87, 27);
            bttExit.TabIndex = 5;
            bttExit.Text = "EXIT";
            bttExit.UseVisualStyleBackColor = false;
            bttExit.Click += eventExit;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 166, 53);
            ClientSize = new Size(584, 361);
            Controls.Add(bttExit);
            Controls.Add(bttStart);
            Controls.Add(imgFood);
            Controls.Add(lblFood);
            Controls.Add(lblVersion);
            Controls.Add(imgSimonSay);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SimonSay - Game";
            FormClosed += eventExit;
            ((System.ComponentModel.ISupportInitialize)imgSimonSay).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgSimonSay;
        private Label lblVersion;
        private Label lblFood;
        private PictureBox imgFood;
        private Button bttStart;
        private Button bttExit;
    }
}