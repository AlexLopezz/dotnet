namespace SimonSayWF
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            panelGame = new Panel();
            bttNoodle_3 = new Button();
            bttEmpanada_1 = new Button();
            bttBurguer_0 = new Button();
            bttSimonSay = new Button();
            lblDescriptionScore = new Label();
            lblScore = new Label();
            bttPizza_2 = new Button();
            panelGame.SuspendLayout();
            SuspendLayout();
            // 
            // panelGame
            // 
            panelGame.Controls.Add(bttNoodle_3);
            panelGame.Controls.Add(bttEmpanada_1);
            panelGame.Controls.Add(bttBurguer_0);
            panelGame.Controls.Add(bttSimonSay);
            panelGame.Controls.Add(lblDescriptionScore);
            panelGame.Controls.Add(lblScore);
            panelGame.Controls.Add(bttPizza_2);
            panelGame.Dock = DockStyle.Fill;
            panelGame.Location = new Point(0, 0);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(484, 311);
            panelGame.TabIndex = 0;
            // 
            // bttNoodle_3
            // 
            bttNoodle_3.FlatAppearance.BorderSize = 0;
            bttNoodle_3.FlatStyle = FlatStyle.Flat;
            bttNoodle_3.Image = SimonSay.Properties.Resources.spaguetti;
            bttNoodle_3.Location = new Point(246, 160);
            bttNoodle_3.Name = "bttNoodle_3";
            bttNoodle_3.Size = new Size(130, 92);
            bttNoodle_3.TabIndex = 8;
            bttNoodle_3.UseVisualStyleBackColor = true;
            bttNoodle_3.Click += clickButton;
            bttNoodle_3.MouseDown += PressButton;
            bttNoodle_3.MouseUp += StopPressButton;
            // 
            // bttEmpanada_1
            // 
            bttEmpanada_1.FlatAppearance.BorderSize = 0;
            bttEmpanada_1.FlatStyle = FlatStyle.Flat;
            bttEmpanada_1.Image = SimonSay.Properties.Resources.empanada;
            bttEmpanada_1.Location = new Point(246, 62);
            bttEmpanada_1.Name = "bttEmpanada_1";
            bttEmpanada_1.Size = new Size(130, 92);
            bttEmpanada_1.TabIndex = 7;
            bttEmpanada_1.UseVisualStyleBackColor = true;
            bttEmpanada_1.Click += clickButton;
            bttEmpanada_1.MouseDown += PressButton;
            bttEmpanada_1.MouseUp += StopPressButton;
            // 
            // bttBurguer_0
            // 
            bttBurguer_0.FlatAppearance.BorderSize = 0;
            bttBurguer_0.FlatStyle = FlatStyle.Flat;
            bttBurguer_0.Image = SimonSay.Properties.Resources.hamburger;
            bttBurguer_0.Location = new Point(110, 62);
            bttBurguer_0.Name = "bttBurguer_0";
            bttBurguer_0.Size = new Size(130, 92);
            bttBurguer_0.TabIndex = 6;
            bttBurguer_0.UseVisualStyleBackColor = true;
            bttBurguer_0.Click += clickButton;
            bttBurguer_0.MouseDown += PressButton;
            bttBurguer_0.MouseUp += StopPressButton;
            // 
            // bttSimonSay
            // 
            bttSimonSay.BackColor = Color.FromArgb(255, 46, 29);
            bttSimonSay.FlatAppearance.BorderSize = 0;
            bttSimonSay.FlatStyle = FlatStyle.Popup;
            bttSimonSay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bttSimonSay.ForeColor = Color.White;
            bttSimonSay.Location = new Point(183, 261);
            bttSimonSay.Name = "bttSimonSay";
            bttSimonSay.Size = new Size(119, 41);
            bttSimonSay.TabIndex = 5;
            bttSimonSay.Text = "SIMON SAY!";
            bttSimonSay.UseVisualStyleBackColor = false;
            bttSimonSay.Click += bttSimonSay_Click;
            // 
            // lblDescriptionScore
            // 
            lblDescriptionScore.AutoSize = true;
            lblDescriptionScore.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescriptionScore.Location = new Point(110, 18);
            lblDescriptionScore.Name = "lblDescriptionScore";
            lblDescriptionScore.Size = new Size(170, 32);
            lblDescriptionScore.TabIndex = 4;
            lblDescriptionScore.Text = "YOUR SCORE: ";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.Location = new Point(274, 14);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(33, 37);
            lblScore.TabIndex = 1;
            lblScore.Text = "0";
            // 
            // bttPizza_2
            // 
            bttPizza_2.FlatAppearance.BorderSize = 0;
            bttPizza_2.FlatStyle = FlatStyle.Flat;
            bttPizza_2.Image = (Image)resources.GetObject("bttPizza_2.Image");
            bttPizza_2.Location = new Point(110, 160);
            bttPizza_2.Name = "bttPizza_2";
            bttPizza_2.Size = new Size(130, 92);
            bttPizza_2.TabIndex = 9;
            bttPizza_2.UseVisualStyleBackColor = true;
            bttPizza_2.Click += clickButton;
            bttPizza_2.MouseDown += PressButton;
            bttPizza_2.MouseUp += StopPressButton;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 166, 53);
            ClientSize = new Size(484, 311);
            Controls.Add(panelGame);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simon Say - Game";
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGame;
        private Label lblDescriptionScore;
        private Button bttSimonSay;
        private Label lblScore;
        private Button bttNoodle_3;
        private Button bttEmpanada_1;
        private Button bttBurguer_0;
        private Button bttPizza_2;
    }
}