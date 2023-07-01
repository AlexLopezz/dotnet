namespace Generador_Lorem_Ipsum
{
    partial class GUI_CountWord
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_CountWord));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblGitHub = new System.Windows.Forms.Label();
            this.bttGitHub = new System.Windows.Forms.Button();
            this.lblParagraph = new System.Windows.Forms.Label();
            this.bttCheck = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblCountWords = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCountSentences = new System.Windows.Forms.Label();
            this.lblLetters = new System.Windows.Forms.Label();
            this.lblCountParagraph = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblCountLetters = new System.Windows.Forms.Label();
            this.lblSentences = new System.Windows.Forms.Label();
            this.txtBoard = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblGitHub);
            this.splitContainer1.Panel1.Controls.Add(this.bttGitHub);
            this.splitContainer1.Panel1.Controls.Add(this.lblParagraph);
            this.splitContainer1.Panel1.Controls.Add(this.bttCheck);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.txtBoard);
            this.splitContainer1.Size = new System.Drawing.Size(584, 361);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGitHub.Location = new System.Drawing.Point(31, 251);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(143, 20);
            this.lblGitHub.TabIndex = 12;
            this.lblGitHub.Text = "Code on GitHub!";
            // 
            // bttGitHub
            // 
            this.bttGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.bttGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttGitHub.Image = ((System.Drawing.Image)(resources.GetObject("bttGitHub.Image")));
            this.bttGitHub.Location = new System.Drawing.Point(52, 274);
            this.bttGitHub.Name = "bttGitHub";
            this.bttGitHub.Size = new System.Drawing.Size(99, 64);
            this.bttGitHub.TabIndex = 11;
            this.bttGitHub.UseVisualStyleBackColor = false;
            // 
            // lblParagraph
            // 
            this.lblParagraph.AutoSize = true;
            this.lblParagraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParagraph.Location = new System.Drawing.Point(11, 165);
            this.lblParagraph.Name = "lblParagraph";
            this.lblParagraph.Size = new System.Drawing.Size(112, 24);
            this.lblParagraph.TabIndex = 10;
            this.lblParagraph.Text = "Paragraph:";
            // 
            // bttCheck
            // 
            this.bttCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bttCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCheck.Location = new System.Drawing.Point(15, 11);
            this.bttCheck.Name = "bttCheck";
            this.bttCheck.Size = new System.Drawing.Size(159, 34);
            this.bttCheck.TabIndex = 7;
            this.bttCheck.Text = "CHECK";
            this.bttCheck.UseVisualStyleBackColor = false;
            this.bttCheck.Click += new System.EventHandler(this.PressCheck);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblCountWords);
            this.groupBox.Controls.Add(this.lblCount);
            this.groupBox.Controls.Add(this.lblCountSentences);
            this.groupBox.Controls.Add(this.lblLetters);
            this.groupBox.Controls.Add(this.lblCountParagraph);
            this.groupBox.Controls.Add(this.lblWords);
            this.groupBox.Controls.Add(this.lblCountLetters);
            this.groupBox.Controls.Add(this.lblSentences);
            this.groupBox.Location = new System.Drawing.Point(3, 51);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(195, 181);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            // 
            // lblCountWords
            // 
            this.lblCountWords.AutoSize = true;
            this.lblCountWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountWords.ForeColor = System.Drawing.Color.Red;
            this.lblCountWords.Location = new System.Drawing.Point(86, 52);
            this.lblCountWords.Name = "lblCountWords";
            this.lblCountWords.Size = new System.Drawing.Size(19, 20);
            this.lblCountWords.TabIndex = 15;
            this.lblCountWords.Text = "0";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCount.Location = new System.Drawing.Point(44, 11);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(97, 25);
            this.lblCount.TabIndex = 16;
            this.lblCount.Text = "Count of:";
            // 
            // lblCountSentences
            // 
            this.lblCountSentences.AutoSize = true;
            this.lblCountSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSentences.ForeColor = System.Drawing.Color.Red;
            this.lblCountSentences.Location = new System.Drawing.Point(120, 84);
            this.lblCountSentences.Name = "lblCountSentences";
            this.lblCountSentences.Size = new System.Drawing.Size(19, 20);
            this.lblCountSentences.TabIndex = 13;
            this.lblCountSentences.Text = "0";
            // 
            // lblLetters
            // 
            this.lblLetters.AutoSize = true;
            this.lblLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetters.Location = new System.Drawing.Point(8, 147);
            this.lblLetters.Name = "lblLetters";
            this.lblLetters.Size = new System.Drawing.Size(78, 24);
            this.lblLetters.TabIndex = 14;
            this.lblLetters.Text = "Letters:";
            // 
            // lblCountParagraph
            // 
            this.lblCountParagraph.AutoSize = true;
            this.lblCountParagraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountParagraph.ForeColor = System.Drawing.Color.Red;
            this.lblCountParagraph.Location = new System.Drawing.Point(120, 117);
            this.lblCountParagraph.Name = "lblCountParagraph";
            this.lblCountParagraph.Size = new System.Drawing.Size(19, 20);
            this.lblCountParagraph.TabIndex = 12;
            this.lblCountParagraph.Text = "0";
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.Location = new System.Drawing.Point(8, 49);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(82, 24);
            this.lblWords.TabIndex = 8;
            this.lblWords.Text = "Words: ";
            // 
            // lblCountLetters
            // 
            this.lblCountLetters.AutoSize = true;
            this.lblCountLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountLetters.ForeColor = System.Drawing.Color.Red;
            this.lblCountLetters.Location = new System.Drawing.Point(86, 150);
            this.lblCountLetters.Name = "lblCountLetters";
            this.lblCountLetters.Size = new System.Drawing.Size(19, 20);
            this.lblCountLetters.TabIndex = 11;
            this.lblCountLetters.Text = "0";
            // 
            // lblSentences
            // 
            this.lblSentences.AutoSize = true;
            this.lblSentences.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentences.Location = new System.Drawing.Point(8, 81);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(115, 24);
            this.lblSentences.TabIndex = 9;
            this.lblSentences.Text = "Sentences:";
            // 
            // txtBoard
            // 
            this.txtBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoard.Location = new System.Drawing.Point(0, 0);
            this.txtBoard.Multiline = true;
            this.txtBoard.Name = "txtBoard";
            this.txtBoard.Size = new System.Drawing.Size(375, 359);
            this.txtBoard.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos txt (*.txt)|*.txt";
            // 
            // GUI_CountWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GUI_CountWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WordCount by Alex Lopez!";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtBoard;
        private System.Windows.Forms.Button bttCheck;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblParagraph;
        private System.Windows.Forms.Label lblSentences;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblCountLetters;
        private System.Windows.Forms.Label lblCountSentences;
        private System.Windows.Forms.Label lblCountParagraph;
        private System.Windows.Forms.Label lblCountWords;
        private System.Windows.Forms.Label lblLetters;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button bttGitHub;
        private System.Windows.Forms.Label lblGitHub;
    }
}

