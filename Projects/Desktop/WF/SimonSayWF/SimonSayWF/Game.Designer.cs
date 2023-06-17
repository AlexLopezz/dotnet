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
            panel1 = new Panel();
            bttSimonSay = new Button();
            lblJugador = new Label();
            imgNoodle = new PictureBox();
            imgPizza = new PictureBox();
            imgEmpanada = new PictureBox();
            imgBurguer = new PictureBox();
            panel2 = new Panel();
            bttClear = new Button();
            lblScore = new Label();
            listScore = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgNoodle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEmpanada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgBurguer).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bttSimonSay);
            panel1.Controls.Add(lblJugador);
            panel1.Controls.Add(imgNoodle);
            panel1.Controls.Add(imgPizza);
            panel1.Controls.Add(imgEmpanada);
            panel1.Controls.Add(imgBurguer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 311);
            panel1.TabIndex = 0;
            // 
            // bttSimonSay
            // 
            bttSimonSay.BackColor = Color.FromArgb(255, 46, 29);
            bttSimonSay.FlatAppearance.BorderSize = 0;
            bttSimonSay.FlatStyle = FlatStyle.Popup;
            bttSimonSay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bttSimonSay.ForeColor = Color.White;
            bttSimonSay.Location = new Point(153, 258);
            bttSimonSay.Name = "bttSimonSay";
            bttSimonSay.Size = new Size(119, 41);
            bttSimonSay.TabIndex = 5;
            bttSimonSay.Text = "SIMON SAY!";
            bttSimonSay.UseVisualStyleBackColor = false;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblJugador.Location = new Point(12, 9);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(116, 32);
            lblJugador.TabIndex = 4;
            lblJugador.Text = "*PLAYER*";
            // 
            // imgNoodle
            // 
            imgNoodle.Image = Properties.Resources.spaguetti;
            imgNoodle.Location = new Point(216, 157);
            imgNoodle.Name = "imgNoodle";
            imgNoodle.Size = new Size(130, 92);
            imgNoodle.SizeMode = PictureBoxSizeMode.Zoom;
            imgNoodle.TabIndex = 3;
            imgNoodle.TabStop = false;
            // 
            // imgPizza
            // 
            imgPizza.Image = Properties.Resources.pizza;
            imgPizza.Location = new Point(80, 157);
            imgPizza.Name = "imgPizza";
            imgPizza.Size = new Size(130, 92);
            imgPizza.SizeMode = PictureBoxSizeMode.Zoom;
            imgPizza.TabIndex = 2;
            imgPizza.TabStop = false;
            // 
            // imgEmpanada
            // 
            imgEmpanada.Image = Properties.Resources.empanada;
            imgEmpanada.Location = new Point(216, 59);
            imgEmpanada.Name = "imgEmpanada";
            imgEmpanada.Size = new Size(130, 92);
            imgEmpanada.SizeMode = PictureBoxSizeMode.Zoom;
            imgEmpanada.TabIndex = 1;
            imgEmpanada.TabStop = false;
            // 
            // imgBurguer
            // 
            imgBurguer.Image = Properties.Resources.burguer;
            imgBurguer.Location = new Point(80, 59);
            imgBurguer.Name = "imgBurguer";
            imgBurguer.Size = new Size(130, 92);
            imgBurguer.SizeMode = PictureBoxSizeMode.Zoom;
            imgBurguer.TabIndex = 0;
            imgBurguer.TabStop = false;
            imgBurguer.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(bttClear);
            panel2.Controls.Add(lblScore);
            panel2.Controls.Add(listScore);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(411, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 311);
            panel2.TabIndex = 1;
            // 
            // bttClear
            // 
            bttClear.BackColor = Color.Lime;
            bttClear.FlatAppearance.BorderSize = 0;
            bttClear.FlatStyle = FlatStyle.Popup;
            bttClear.Location = new Point(57, 255);
            bttClear.Name = "bttClear";
            bttClear.Size = new Size(75, 26);
            bttClear.TabIndex = 2;
            bttClear.Text = "CLEAR";
            bttClear.UseVisualStyleBackColor = false;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.Location = new Point(57, 22);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(70, 25);
            lblScore.TabIndex = 1;
            lblScore.Text = "SCORE";
            // 
            // listScore
            // 
            listScore.FormattingEnabled = true;
            listScore.ItemHeight = 15;
            listScore.Location = new Point(3, 50);
            listScore.Name = "listScore";
            listScore.Size = new Size(167, 199);
            listScore.TabIndex = 0;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 166, 53);
            ClientSize = new Size(584, 311);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simon Say - Game";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgNoodle).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEmpanada).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgBurguer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblJugador;
        private PictureBox imgNoodle;
        private PictureBox imgPizza;
        private PictureBox imgEmpanada;
        private PictureBox imgBurguer;
        private Panel panel2;
        private Button bttSimonSay;
        private Label lblScore;
        private Button bttClear;
        private ListBox listScore;
    }
}