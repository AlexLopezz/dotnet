namespace SecretFriend.GUI
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
            panelHome = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            bttSave = new Button();
            bttList = new Button();
            bttSecretFriend = new Button();
            lblTitle = new Label();
            panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.FromArgb(255, 192, 128);
            panelHome.Controls.Add(pictureBox4);
            panelHome.Controls.Add(pictureBox3);
            panelHome.Controls.Add(pictureBox2);
            panelHome.Controls.Add(pictureBox1);
            panelHome.Controls.Add(button4);
            panelHome.Controls.Add(bttSave);
            panelHome.Controls.Add(bttList);
            panelHome.Controls.Add(bttSecretFriend);
            panelHome.Controls.Add(lblTitle);
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(0, 0);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(584, 361);
            panelHome.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.quit;
            pictureBox4.Location = new Point(93, 281);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 68);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.save_disk;
            pictureBox3.Location = new Point(94, 207);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.list;
            pictureBox2.Location = new Point(94, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.input;
            pictureBox1.Location = new Point(93, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(199, 281);
            button4.Name = "button4";
            button4.Size = new Size(286, 68);
            button4.TabIndex = 7;
            button4.Text = "¡TERMINAR JUEGO!";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // bttSave
            // 
            bttSave.BackColor = Color.FromArgb(192, 192, 255);
            bttSave.FlatStyle = FlatStyle.Flat;
            bttSave.Location = new Point(200, 207);
            bttSave.Name = "bttSave";
            bttSave.Size = new Size(286, 68);
            bttSave.TabIndex = 6;
            bttSave.Text = "GUARDAR LISTA DE PARTICIPANTES CON SUS RESPECTIVOS AMIGOS INVISIBLES";
            bttSave.UseVisualStyleBackColor = false;
            bttSave.Click += PressSaveButton;
            // 
            // bttList
            // 
            bttList.BackColor = Color.FromArgb(128, 255, 128);
            bttList.FlatStyle = FlatStyle.Flat;
            bttList.Location = new Point(200, 133);
            bttList.Name = "bttList";
            bttList.Size = new Size(286, 68);
            bttList.TabIndex = 5;
            bttList.Text = "VER LISTA DE TODOS LOS PARTICIPANTES CON SUS RESPECTIVOS AMIGOS INVISIBLES";
            bttList.UseVisualStyleBackColor = false;
            bttList.Click += PressListButton;
            // 
            // bttSecretFriend
            // 
            bttSecretFriend.BackColor = Color.FromArgb(255, 255, 128);
            bttSecretFriend.FlatStyle = FlatStyle.Flat;
            bttSecretFriend.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            bttSecretFriend.Location = new Point(199, 59);
            bttSecretFriend.Name = "bttSecretFriend";
            bttSecretFriend.Size = new Size(286, 68);
            bttSecretFriend.TabIndex = 4;
            bttSecretFriend.Text = "INGRESAR NOMBRE PARTICIPANTE PARA SABER SU AMIGO INVISIBLE";
            bttSecretFriend.UseVisualStyleBackColor = false;
            bttSecretFriend.Click += bttSecretFriend_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(161, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 37);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "¡AMIGO INVISIBLE!";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(panelHome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¿Que desea realizar?";
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHome;
        private Label lblTitle;
        private Button bttSave;
        private Button bttList;
        private Button bttSecretFriend;
        private Button button4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}