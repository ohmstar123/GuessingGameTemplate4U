namespace GuessingGameTemplate4U
{
    partial class FinishScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gotitLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.guessesLabel = new System.Windows.Forms.Label();
            this.orginalLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gotitLabel
            // 
            this.gotitLabel.AutoSize = true;
            this.gotitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotitLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gotitLabel.Location = new System.Drawing.Point(34, 25);
            this.gotitLabel.Name = "gotitLabel";
            this.gotitLabel.Size = new System.Drawing.Size(126, 30);
            this.gotitLabel.TabIndex = 0;
            this.gotitLabel.Text = "You got it!";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultLabel.Location = new System.Drawing.Point(34, 69);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(99, 29);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Results ";
            // 
            // guessesLabel
            // 
            this.guessesLabel.AutoSize = true;
            this.guessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guessesLabel.Location = new System.Drawing.Point(34, 139);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(193, 29);
            this.guessesLabel.TabIndex = 2;
            this.guessesLabel.Text = "Guesses made : ";
            // 
            // orginalLabel
            // 
            this.orginalLabel.AutoSize = true;
            this.orginalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orginalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.orginalLabel.Location = new System.Drawing.Point(34, 218);
            this.orginalLabel.Name = "orginalLabel";
            this.orginalLabel.Size = new System.Drawing.Size(180, 29);
            this.orginalLabel.TabIndex = 3;
            this.orginalLabel.Text = "Original order : ";
            // 
            // sortedLabel
            // 
            this.sortedLabel.AutoSize = true;
            this.sortedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sortedLabel.Location = new System.Drawing.Point(34, 318);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(167, 29);
            this.sortedLabel.TabIndex = 4;
            this.sortedLabel.Text = "Sorted order : ";
            // 
            // FinishScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.orginalLabel);
            this.Controls.Add(this.guessesLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.gotitLabel);
            this.Name = "FinishScreen";
            this.Size = new System.Drawing.Size(472, 518);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gotitLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.Label orginalLabel;
        private System.Windows.Forms.Label sortedLabel;
    }
}
