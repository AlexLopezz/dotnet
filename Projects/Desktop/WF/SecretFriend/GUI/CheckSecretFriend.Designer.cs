namespace SecretFriend.GUI
{
    partial class CheckSecretFriend
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
            panelSecretFriend = new Panel();
            txtSecretFriend = new TextBox();
            label2 = new Label();
            lblTitle = new Label();
            label1 = new Label();
            lblName = new Label();
            txtName = new TextBox();
            bttCheck = new Button();
            panelSecretFriend.SuspendLayout();
            SuspendLayout();
            // 
            // panelSecretFriend
            // 
            panelSecretFriend.BackColor = Color.FromArgb(255, 192, 128);
            panelSecretFriend.Controls.Add(txtSecretFriend);
            panelSecretFriend.Controls.Add(label2);
            panelSecretFriend.Controls.Add(lblTitle);
            panelSecretFriend.Controls.Add(label1);
            panelSecretFriend.Controls.Add(lblName);
            panelSecretFriend.Controls.Add(txtName);
            panelSecretFriend.Controls.Add(bttCheck);
            panelSecretFriend.Dock = DockStyle.Fill;
            panelSecretFriend.Location = new Point(0, 0);
            panelSecretFriend.Name = "panelSecretFriend";
            panelSecretFriend.Size = new Size(451, 235);
            panelSecretFriend.TabIndex = 0;
            // 
            // txtSecretFriend
            // 
            txtSecretFriend.BorderStyle = BorderStyle.None;
            txtSecretFriend.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSecretFriend.Location = new Point(123, 188);
            txtSecretFriend.Name = "txtSecretFriend";
            txtSecretFriend.PlaceholderText = "Ingrese su nombre para saberlo";
            txtSecretFriend.ReadOnly = true;
            txtSecretFriend.Size = new Size(208, 15);
            txtSecretFriend.TabIndex = 7;
            txtSecretFriend.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(137, 168);
            label2.Name = "label2";
            label2.Size = new Size(174, 17);
            label2.TabIndex = 6;
            label2.Text = "TU AMIGO/A INVISIBLE ES:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(104, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 37);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "¡AMIGO INVISIBLE!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(164, 45);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 4;
            label1.Text = "¡PARTICIPANTE!";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(150, 66);
            lblName.Name = "lblName";
            lblName.Size = new Size(165, 21);
            lblName.TabIndex = 2;
            lblName.Text = "INGRESE SU NOMBRE";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(123, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 29);
            txtName.TabIndex = 1;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // bttCheck
            // 
            bttCheck.BackColor = Color.Lime;
            bttCheck.FlatStyle = FlatStyle.Popup;
            bttCheck.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttCheck.Location = new Point(137, 125);
            bttCheck.Name = "bttCheck";
            bttCheck.Size = new Size(178, 37);
            bttCheck.TabIndex = 0;
            bttCheck.Text = "VERIFICAR AMIGO INVISIBLE";
            bttCheck.UseVisualStyleBackColor = false;
            bttCheck.Click += bttCheck_Click;
            // 
            // CheckSecretFriend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 235);
            Controls.Add(panelSecretFriend);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CheckSecretFriend";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¿Quien es tu amigo invisible?";
            panelSecretFriend.ResumeLayout(false);
            panelSecretFriend.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSecretFriend;
        private TextBox txtName;
        private Button bttCheck;
        private Label lblName;
        private Label label1;
        private Label lblTitle;
        private Label label2;
        private TextBox txtSecretFriend;
    }
}