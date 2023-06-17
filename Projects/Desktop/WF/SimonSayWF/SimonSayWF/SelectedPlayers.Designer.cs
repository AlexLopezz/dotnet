namespace SimonSayWF
{
    partial class SelectedPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectedPlayers));
            panel1 = new Panel();
            panel2 = new Panel();
            bttOK = new Button();
            splitContainer1 = new SplitContainer();
            txtPlayer1 = new TextBox();
            profilePlayer1 = new PictureBox();
            lblPlayer1 = new Label();
            txtPlayer2 = new TextBox();
            profilePlayer2 = new PictureBox();
            lblPlayer2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilePlayer2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 311);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(bttOK);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 246);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 65);
            panel2.TabIndex = 0;
            // 
            // bttOK
            // 
            bttOK.BackColor = Color.FromArgb(87, 255, 53);
            bttOK.FlatAppearance.BorderSize = 0;
            bttOK.FlatStyle = FlatStyle.Popup;
            bttOK.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttOK.Location = new Point(204, 3);
            bttOK.Name = "bttOK";
            bttOK.Size = new Size(196, 59);
            bttOK.TabIndex = 0;
            bttOK.Text = "TO PLAY!";
            bttOK.UseVisualStyleBackColor = false;
            bttOK.Click += eventPlay;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtPlayer1);
            splitContainer1.Panel1.Controls.Add(profilePlayer1);
            splitContainer1.Panel1.Controls.Add(lblPlayer1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtPlayer2);
            splitContainer1.Panel2.Controls.Add(profilePlayer2);
            splitContainer1.Panel2.Controls.Add(lblPlayer2);
            splitContainer1.Size = new Size(584, 311);
            splitContainer1.SplitterDistance = 285;
            splitContainer1.TabIndex = 1;
            // 
            // txtPlayer1
            // 
            txtPlayer1.Location = new Point(68, 173);
            txtPlayer1.Name = "txtPlayer1";
            txtPlayer1.Size = new Size(117, 23);
            txtPlayer1.TabIndex = 0;
            // 
            // profilePlayer1
            // 
            profilePlayer1.Image = Properties.Resources.perfil;
            profilePlayer1.Location = new Point(52, 55);
            profilePlayer1.Name = "profilePlayer1";
            profilePlayer1.Size = new Size(150, 112);
            profilePlayer1.SizeMode = PictureBoxSizeMode.Zoom;
            profilePlayer1.TabIndex = 1;
            profilePlayer1.TabStop = false;
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer1.Location = new Point(68, 27);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(117, 25);
            lblPlayer1.TabIndex = 0;
            lblPlayer1.Text = "JUGADOR 1";
            // 
            // txtPlayer2
            // 
            txtPlayer2.Location = new Point(110, 173);
            txtPlayer2.Name = "txtPlayer2";
            txtPlayer2.Size = new Size(117, 23);
            txtPlayer2.TabIndex = 1;
            // 
            // profilePlayer2
            // 
            profilePlayer2.Image = Properties.Resources.perfil;
            profilePlayer2.Location = new Point(90, 55);
            profilePlayer2.Name = "profilePlayer2";
            profilePlayer2.Size = new Size(150, 112);
            profilePlayer2.SizeMode = PictureBoxSizeMode.Zoom;
            profilePlayer2.TabIndex = 4;
            profilePlayer2.TabStop = false;
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer2.Location = new Point(110, 27);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(117, 25);
            lblPlayer2.TabIndex = 3;
            lblPlayer2.Text = "JUGADOR 2";
            // 
            // SelectedPlayers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 166, 53);
            ClientSize = new Size(584, 311);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SelectedPlayers";
            Text = "Name of Players!";
            FormClosed += formClosed;
            Load += SelectedPlayers_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profilePlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilePlayer2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private Splitter splitter1;
        private Button bttOK;
        private Panel panel2;
        private TextBox txtPlayer1;
        private PictureBox profilePlayer1;
        private Label lblPlayer1;
        private TextBox txtPlayer2;
        private PictureBox profilePlayer2;
        private Label lblPlayer2;
    }
}