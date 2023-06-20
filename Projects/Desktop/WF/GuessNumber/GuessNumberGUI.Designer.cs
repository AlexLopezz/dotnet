namespace GuessNumber
{
    partial class GuessNumberGUI
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
            panel2 = new Panel();
            txtHint = new TextBox();
            bttHint = new Button();
            bttTry = new Button();
            txtNumber = new TextBox();
            lblGuessNumber = new Label();
            panel1 = new Panel();
            lblRandomNumber = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtHint);
            panel2.Controls.Add(bttHint);
            panel2.Controls.Add(bttTry);
            panel2.Controls.Add(txtNumber);
            panel2.Controls.Add(lblGuessNumber);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 311);
            panel2.TabIndex = 1;
            // 
            // txtHint
            // 
            txtHint.BackColor = SystemColors.Control;
            txtHint.Location = new Point(42, 212);
            txtHint.Multiline = true;
            txtHint.Name = "txtHint";
            txtHint.ReadOnly = true;
            txtHint.Size = new Size(220, 77);
            txtHint.TabIndex = 6;
            txtHint.Text = "Aren't you sure? Press the button Hint!";
            // 
            // bttHint
            // 
            bttHint.BackColor = Color.Red;
            bttHint.FlatStyle = FlatStyle.Flat;
            bttHint.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            bttHint.Location = new Point(124, 183);
            bttHint.Name = "bttHint";
            bttHint.Size = new Size(48, 23);
            bttHint.TabIndex = 5;
            bttHint.Text = "Hint?";
            bttHint.UseVisualStyleBackColor = false;
            bttHint.Click += bttHint_Click;
            // 
            // bttTry
            // 
            bttTry.BackColor = Color.Lime;
            bttTry.FlatStyle = FlatStyle.Flat;
            bttTry.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            bttTry.Location = new Point(116, 150);
            bttTry.Name = "bttTry";
            bttTry.Size = new Size(64, 27);
            bttTry.TabIndex = 3;
            bttTry.Text = "Try!";
            bttTry.UseVisualStyleBackColor = false;
            bttTry.Click += bttTry_Click;
            // 
            // txtNumber
            // 
            txtNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNumber.BackColor = SystemColors.Control;
            txtNumber.BorderStyle = BorderStyle.None;
            txtNumber.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumber.Location = new Point(116, 108);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(52, 36);
            txtNumber.TabIndex = 2;
            txtNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGuessNumber
            // 
            lblGuessNumber.AutoSize = true;
            lblGuessNumber.Dock = DockStyle.Top;
            lblGuessNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGuessNumber.ForeColor = Color.Blue;
            lblGuessNumber.Location = new Point(0, 0);
            lblGuessNumber.Name = "lblGuessNumber";
            lblGuessNumber.Size = new Size(157, 21);
            lblGuessNumber.TabIndex = 0;
            lblGuessNumber.Text = "Guess the Number! :)";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRandomNumber);
            panel1.Location = new Point(124, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(48, 59);
            panel1.TabIndex = 7;
            // 
            // lblRandomNumber
            // 
            lblRandomNumber.AutoSize = true;
            lblRandomNumber.Dock = DockStyle.Fill;
            lblRandomNumber.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblRandomNumber.Location = new Point(0, 0);
            lblRandomNumber.Name = "lblRandomNumber";
            lblRandomNumber.Size = new Size(49, 65);
            lblRandomNumber.TabIndex = 1;
            lblRandomNumber.Text = "?";
            // 
            // GuessNumberGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 311);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GuessNumberGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Development by Alex Lopez!";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtHint;
        private Button bttHint;
        private Button bttTry;
        private TextBox txtNumber;
        private Label lblRandomNumber;
        private Label label1;
        private Label lblGuessNumber;
        private Panel panel1;
    }
}