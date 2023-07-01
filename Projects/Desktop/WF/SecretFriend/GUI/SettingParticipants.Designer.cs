namespace SecretFriend.GUI
{
    partial class SettingParticipants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingParticipants));
            pictureBox1 = new PictureBox();
            bttReady = new Button();
            bttReset = new Button();
            lblTitle = new Label();
            bttOK = new Button();
            cboCountParticipants = new ComboBox();
            label1 = new Label();
            lboParticipants = new ListBox();
            panelSettings = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image_about_friends;
            pictureBox1.Location = new Point(368, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // bttReady
            // 
            bttReady.BackColor = Color.FromArgb(128, 255, 128);
            bttReady.FlatStyle = FlatStyle.Popup;
            bttReady.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttReady.Location = new Point(187, 395);
            bttReady.Name = "bttReady";
            bttReady.Size = new Size(75, 37);
            bttReady.TabIndex = 14;
            bttReady.Text = "¡LISTO!";
            bttReady.UseVisualStyleBackColor = false;
            bttReady.Click += bttReady_Click;
            // 
            // bttReset
            // 
            bttReset.BackColor = Color.FromArgb(128, 255, 255);
            bttReset.FlatStyle = FlatStyle.Popup;
            bttReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bttReset.Location = new Point(80, 390);
            bttReset.Name = "bttReset";
            bttReset.Size = new Size(101, 48);
            bttReset.TabIndex = 13;
            bttReset.Text = "CONFIGURAR DE NUEVO";
            bttReset.UseVisualStyleBackColor = false;
            bttReset.Click += bttReset_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(47, 133);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 17);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "¡Todos los nombres de los participantes!";
            // 
            // bttOK
            // 
            bttOK.BackColor = Color.FromArgb(64, 64, 64);
            bttOK.FlatStyle = FlatStyle.Popup;
            bttOK.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttOK.ForeColor = Color.White;
            bttOK.Location = new Point(220, 95);
            bttOK.Name = "bttOK";
            bttOK.Size = new Size(50, 25);
            bttOK.TabIndex = 11;
            bttOK.Text = "OK";
            bttOK.UseVisualStyleBackColor = false;
            bttOK.Click += PressOK;
            // 
            // cboCountParticipants
            // 
            cboCountParticipants.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCountParticipants.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboCountParticipants.FormattingEnabled = true;
            cboCountParticipants.Items.AddRange(new object[] { "Seleccione cantidad", "2", "4", "6", "8", "10", "12", "14", "16", "18", "20" });
            cboCountParticipants.Location = new Point(47, 95);
            cboCountParticipants.Name = "cboCountParticipants";
            cboCountParticipants.Size = new Size(167, 25);
            cboCountParticipants.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 71);
            label1.Name = "label1";
            label1.Size = new Size(253, 21);
            label1.TabIndex = 9;
            label1.Text = "¿Cuantos participantes jugaran?";
            // 
            // lboParticipants
            // 
            lboParticipants.FormattingEnabled = true;
            lboParticipants.ItemHeight = 15;
            lboParticipants.Location = new Point(47, 153);
            lboParticipants.Name = "lboParticipants";
            lboParticipants.Size = new Size(253, 229);
            lboParticipants.TabIndex = 8;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.FromArgb(255, 192, 128);
            panelSettings.Controls.Add(label3);
            panelSettings.Controls.Add(label2);
            panelSettings.Controls.Add(bttReady);
            panelSettings.Controls.Add(pictureBox1);
            panelSettings.Controls.Add(bttReset);
            panelSettings.Controls.Add(lboParticipants);
            panelSettings.Controls.Add(lblTitle);
            panelSettings.Controls.Add(label1);
            panelSettings.Controls.Add(bttOK);
            panelSettings.Controls.Add(cboCountParticipants);
            panelSettings.Controls.Add(pictureBox2);
            panelSettings.Dock = DockStyle.Fill;
            panelSettings.Location = new Point(0, 0);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(584, 450);
            panelSettings.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(9, 9);
            label3.Name = "label3";
            label3.Size = new Size(261, 37);
            label3.TabIndex = 18;
            label3.Text = "¡AMIGO INVISIBLE!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_about_friends_2_;
            pictureBox2.Location = new Point(368, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // SettingParticipants
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 450);
            Controls.Add(panelSettings);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingParticipants";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracion de participantes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bttReady;
        private Button bttReset;
        private Label lblTitle;
        private Button bttOK;
        private ComboBox cboCountParticipants;
        private Label label1;
        private ListBox lboParticipants;
        private Panel panelSettings;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}