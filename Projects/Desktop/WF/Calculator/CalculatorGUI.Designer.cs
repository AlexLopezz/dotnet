namespace Calculator
{
    partial class CalculatorGUI
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            bttPoint = new Button();
            btt0 = new Button();
            btt3 = new Button();
            btt2 = new Button();
            btt1 = new Button();
            btt6 = new Button();
            btt5 = new Button();
            btt4 = new Button();
            btt9 = new Button();
            btt8 = new Button();
            btt7 = new Button();
            bttGitHub = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            bttEqual = new Button();
            bttSum = new Button();
            bttSubstract = new Button();
            bttMultiplication = new Button();
            bttDivision = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            bttNightMode = new Button();
            bttDelete = new Button();
            bttClear = new Button();
            txtDisplayCalculator = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(384, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.63129F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.3687134F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 227);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(378, 331);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Controls.Add(bttPoint, 2, 3);
            tableLayoutPanel3.Controls.Add(btt0, 1, 3);
            tableLayoutPanel3.Controls.Add(btt3, 2, 2);
            tableLayoutPanel3.Controls.Add(btt2, 1, 2);
            tableLayoutPanel3.Controls.Add(btt1, 0, 2);
            tableLayoutPanel3.Controls.Add(btt6, 2, 1);
            tableLayoutPanel3.Controls.Add(btt5, 1, 1);
            tableLayoutPanel3.Controls.Add(btt4, 0, 1);
            tableLayoutPanel3.Controls.Add(btt9, 2, 0);
            tableLayoutPanel3.Controls.Add(btt8, 1, 0);
            tableLayoutPanel3.Controls.Add(btt7, 0, 0);
            tableLayoutPanel3.Controls.Add(bttGitHub, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(283, 325);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // bttPoint
            // 
            bttPoint.Dock = DockStyle.Fill;
            bttPoint.FlatAppearance.BorderSize = 0;
            bttPoint.FlatStyle = FlatStyle.Flat;
            bttPoint.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bttPoint.Location = new Point(191, 246);
            bttPoint.Name = "bttPoint";
            bttPoint.Size = new Size(89, 76);
            bttPoint.TabIndex = 11;
            bttPoint.Text = ".";
            bttPoint.UseVisualStyleBackColor = true;
            bttPoint.Click += pressButton;
            // 
            // btt0
            // 
            btt0.Dock = DockStyle.Fill;
            btt0.FlatAppearance.BorderSize = 0;
            btt0.FlatStyle = FlatStyle.Flat;
            btt0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt0.Location = new Point(97, 246);
            btt0.Name = "btt0";
            btt0.Size = new Size(88, 76);
            btt0.TabIndex = 10;
            btt0.Text = "0";
            btt0.UseVisualStyleBackColor = true;
            btt0.Click += pressButton;
            // 
            // btt3
            // 
            btt3.Dock = DockStyle.Fill;
            btt3.FlatAppearance.BorderSize = 0;
            btt3.FlatStyle = FlatStyle.Flat;
            btt3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt3.Location = new Point(191, 165);
            btt3.Name = "btt3";
            btt3.Size = new Size(89, 75);
            btt3.TabIndex = 9;
            btt3.Text = "3";
            btt3.UseVisualStyleBackColor = true;
            btt3.Click += pressButton;
            // 
            // btt2
            // 
            btt2.Dock = DockStyle.Fill;
            btt2.FlatAppearance.BorderSize = 0;
            btt2.FlatStyle = FlatStyle.Flat;
            btt2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt2.Location = new Point(97, 165);
            btt2.Name = "btt2";
            btt2.Size = new Size(88, 75);
            btt2.TabIndex = 8;
            btt2.Text = "2";
            btt2.UseVisualStyleBackColor = true;
            btt2.Click += pressButton;
            // 
            // btt1
            // 
            btt1.Dock = DockStyle.Fill;
            btt1.FlatAppearance.BorderSize = 0;
            btt1.FlatStyle = FlatStyle.Flat;
            btt1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt1.Location = new Point(3, 165);
            btt1.Name = "btt1";
            btt1.Size = new Size(88, 75);
            btt1.TabIndex = 7;
            btt1.Text = "1";
            btt1.UseVisualStyleBackColor = true;
            btt1.Click += pressButton;
            // 
            // btt6
            // 
            btt6.Dock = DockStyle.Fill;
            btt6.FlatAppearance.BorderSize = 0;
            btt6.FlatStyle = FlatStyle.Flat;
            btt6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt6.Location = new Point(191, 84);
            btt6.Name = "btt6";
            btt6.Size = new Size(89, 75);
            btt6.TabIndex = 6;
            btt6.Text = "6";
            btt6.UseVisualStyleBackColor = true;
            btt6.Click += pressButton;
            // 
            // btt5
            // 
            btt5.Dock = DockStyle.Fill;
            btt5.FlatAppearance.BorderSize = 0;
            btt5.FlatStyle = FlatStyle.Flat;
            btt5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt5.Location = new Point(97, 84);
            btt5.Name = "btt5";
            btt5.Size = new Size(88, 75);
            btt5.TabIndex = 5;
            btt5.Text = "5";
            btt5.UseVisualStyleBackColor = true;
            btt5.Click += pressButton;
            // 
            // btt4
            // 
            btt4.Dock = DockStyle.Fill;
            btt4.FlatAppearance.BorderSize = 0;
            btt4.FlatStyle = FlatStyle.Flat;
            btt4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt4.Location = new Point(3, 84);
            btt4.Name = "btt4";
            btt4.Size = new Size(88, 75);
            btt4.TabIndex = 4;
            btt4.Text = "4";
            btt4.UseVisualStyleBackColor = true;
            btt4.Click += pressButton;
            // 
            // btt9
            // 
            btt9.Dock = DockStyle.Fill;
            btt9.FlatAppearance.BorderSize = 0;
            btt9.FlatStyle = FlatStyle.Flat;
            btt9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt9.Location = new Point(191, 3);
            btt9.Name = "btt9";
            btt9.Size = new Size(89, 75);
            btt9.TabIndex = 3;
            btt9.Text = "9";
            btt9.UseVisualStyleBackColor = true;
            btt9.Click += pressButton;
            // 
            // btt8
            // 
            btt8.Dock = DockStyle.Fill;
            btt8.FlatAppearance.BorderSize = 0;
            btt8.FlatStyle = FlatStyle.Flat;
            btt8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt8.Location = new Point(97, 3);
            btt8.Name = "btt8";
            btt8.Size = new Size(88, 75);
            btt8.TabIndex = 2;
            btt8.Text = "8";
            btt8.UseVisualStyleBackColor = true;
            btt8.Click += pressButton;
            // 
            // btt7
            // 
            btt7.Dock = DockStyle.Fill;
            btt7.FlatAppearance.BorderSize = 0;
            btt7.FlatStyle = FlatStyle.Flat;
            btt7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btt7.Location = new Point(3, 3);
            btt7.Name = "btt7";
            btt7.Size = new Size(88, 75);
            btt7.TabIndex = 1;
            btt7.Text = "7";
            btt7.UseVisualStyleBackColor = true;
            btt7.Click += pressButton;
            // 
            // bttGitHub
            // 
            bttGitHub.BackColor = Color.FromArgb(255, 195, 0);
            bttGitHub.Dock = DockStyle.Fill;
            bttGitHub.FlatStyle = FlatStyle.Popup;
            bttGitHub.Image = Properties.Resources.github_light;
            bttGitHub.Location = new Point(3, 246);
            bttGitHub.Name = "bttGitHub";
            bttGitHub.Size = new Size(88, 76);
            bttGitHub.TabIndex = 0;
            bttGitHub.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(bttEqual, 0, 4);
            tableLayoutPanel4.Controls.Add(bttSum, 0, 3);
            tableLayoutPanel4.Controls.Add(bttSubstract, 0, 2);
            tableLayoutPanel4.Controls.Add(bttMultiplication, 0, 1);
            tableLayoutPanel4.Controls.Add(bttDivision, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(292, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 27.272728F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(83, 325);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // bttEqual
            // 
            bttEqual.BackColor = SystemColors.ActiveCaption;
            bttEqual.Dock = DockStyle.Fill;
            bttEqual.FlatStyle = FlatStyle.Flat;
            bttEqual.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttEqual.Location = new Point(3, 239);
            bttEqual.Name = "bttEqual";
            bttEqual.Size = new Size(77, 83);
            bttEqual.TabIndex = 0;
            bttEqual.Text = "=";
            bttEqual.UseVisualStyleBackColor = false;
            bttEqual.Click += PressEqual;
            // 
            // bttSum
            // 
            bttSum.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttSum.Location = new Point(3, 180);
            bttSum.Name = "bttSum";
            bttSum.Size = new Size(77, 53);
            bttSum.TabIndex = 3;
            bttSum.Text = "+";
            bttSum.UseVisualStyleBackColor = true;
            bttSum.Click += PressSum;
            // 
            // bttSubstract
            // 
            bttSubstract.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttSubstract.Location = new Point(3, 121);
            bttSubstract.Name = "bttSubstract";
            bttSubstract.Size = new Size(77, 53);
            bttSubstract.TabIndex = 2;
            bttSubstract.Text = "-";
            bttSubstract.UseVisualStyleBackColor = true;
            bttSubstract.Click += PressSubstract;
            // 
            // bttMultiplication
            // 
            bttMultiplication.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttMultiplication.Location = new Point(3, 62);
            bttMultiplication.Name = "bttMultiplication";
            bttMultiplication.Size = new Size(77, 53);
            bttMultiplication.TabIndex = 1;
            bttMultiplication.Text = "X";
            bttMultiplication.UseVisualStyleBackColor = true;
            bttMultiplication.Click += PressMultiplication;
            // 
            // bttDivision
            // 
            bttDivision.Dock = DockStyle.Fill;
            bttDivision.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bttDivision.Location = new Point(3, 3);
            bttDivision.Name = "bttDivision";
            bttDivision.Size = new Size(77, 53);
            bttDivision.TabIndex = 4;
            bttDivision.Text = "/";
            bttDivision.UseVisualStyleBackColor = true;
            bttDivision.Click += PressDivision;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Controls.Add(txtDisplayCalculator, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 61.0091743F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 38.9908257F));
            tableLayoutPanel5.Size = new Size(378, 218);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.46154F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0769234F));
            tableLayoutPanel6.Controls.Add(bttNightMode, 2, 0);
            tableLayoutPanel6.Controls.Add(bttDelete, 1, 0);
            tableLayoutPanel6.Controls.Add(bttClear, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 136);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(372, 79);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // bttNightMode
            // 
            bttNightMode.Dock = DockStyle.Fill;
            bttNightMode.Image = Properties.Resources.night_light;
            bttNightMode.Location = new Point(289, 3);
            bttNightMode.Name = "bttNightMode";
            bttNightMode.Size = new Size(80, 73);
            bttNightMode.TabIndex = 2;
            bttNightMode.UseVisualStyleBackColor = true;
            bttNightMode.Click += PressNightMode;
            // 
            // bttDelete
            // 
            bttDelete.BackColor = Color.FromArgb(255, 128, 0);
            bttDelete.Dock = DockStyle.Fill;
            bttDelete.FlatStyle = FlatStyle.Flat;
            bttDelete.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttDelete.Location = new Point(146, 3);
            bttDelete.Name = "bttDelete";
            bttDelete.Size = new Size(137, 73);
            bttDelete.TabIndex = 1;
            bttDelete.Text = "DELETE";
            bttDelete.UseVisualStyleBackColor = false;
            bttDelete.Click += PressDelete;
            // 
            // bttClear
            // 
            bttClear.BackColor = Color.FromArgb(255, 128, 128);
            bttClear.Dock = DockStyle.Fill;
            bttClear.FlatStyle = FlatStyle.Flat;
            bttClear.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bttClear.Location = new Point(3, 3);
            bttClear.Name = "bttClear";
            bttClear.Size = new Size(137, 73);
            bttClear.TabIndex = 0;
            bttClear.Text = "CLEAR";
            bttClear.UseVisualStyleBackColor = false;
            bttClear.Click += PressClear;
            // 
            // txtDisplayCalculator
            // 
            txtDisplayCalculator.BackColor = Color.FromArgb(192, 255, 192);
            txtDisplayCalculator.BorderStyle = BorderStyle.None;
            txtDisplayCalculator.Dock = DockStyle.Fill;
            txtDisplayCalculator.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisplayCalculator.Location = new Point(3, 3);
            txtDisplayCalculator.Multiline = true;
            txtDisplayCalculator.Name = "txtDisplayCalculator";
            txtDisplayCalculator.Size = new Size(372, 127);
            txtDisplayCalculator.TabIndex = 1;
            txtDisplayCalculator.Text = "0";
            // 
            // CalculatorGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CalculatorGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator by Alex Lopez!";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button bttPoint;
        private Button btt0;
        private Button btt3;
        private Button btt2;
        private Button btt1;
        private Button btt6;
        private Button btt5;
        private Button btt4;
        private Button btt9;
        private Button btt8;
        private Button btt7;
        private Button bttGitHub;
        private Button bttSum;
        private Button bttSubstract;
        private Button bttMultiplication;
        private Button bttEqual;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtDisplayCalculator;
        private Button bttNightMode;
        private Button bttDelete;
        private Button bttClear;
        private Button bttDivision;
    }
}