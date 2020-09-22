namespace GuessingGameTemplate4U
{
    partial class ResultsScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.sortedLabel = new System.Windows.Forms.Label();
            this.sortedTitleLabel = new System.Windows.Forms.Label();
            this.originalTitleLabel = new System.Windows.Forms.Label();
            this.numberTitleLabel = new System.Windows.Forms.Label();
            this.numberOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(21, 24);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(116, 42);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Results:";
            // 
            // orderLabel
            // 
            this.orderLabel.BackColor = System.Drawing.Color.DimGray;
            this.orderLabel.Location = new System.Drawing.Point(25, 134);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(291, 69);
            this.orderLabel.TabIndex = 1;
            // 
            // sortedLabel
            // 
            this.sortedLabel.BackColor = System.Drawing.Color.DimGray;
            this.sortedLabel.Location = new System.Drawing.Point(25, 226);
            this.sortedLabel.Name = "sortedLabel";
            this.sortedLabel.Size = new System.Drawing.Size(291, 69);
            this.sortedLabel.TabIndex = 2;
            // 
            // sortedTitleLabel
            // 
            this.sortedTitleLabel.AutoSize = true;
            this.sortedTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortedTitleLabel.ForeColor = System.Drawing.Color.White;
            this.sortedTitleLabel.Location = new System.Drawing.Point(24, 203);
            this.sortedTitleLabel.Name = "sortedTitleLabel";
            this.sortedTitleLabel.Size = new System.Drawing.Size(118, 23);
            this.sortedTitleLabel.TabIndex = 3;
            this.sortedTitleLabel.Text = "Sorted results:";
            // 
            // originalTitleLabel
            // 
            this.originalTitleLabel.AutoSize = true;
            this.originalTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalTitleLabel.ForeColor = System.Drawing.Color.White;
            this.originalTitleLabel.Location = new System.Drawing.Point(24, 111);
            this.originalTitleLabel.Name = "originalTitleLabel";
            this.originalTitleLabel.Size = new System.Drawing.Size(128, 23);
            this.originalTitleLabel.TabIndex = 4;
            this.originalTitleLabel.Text = "Original results:";
            // 
            // numberTitleLabel
            // 
            this.numberTitleLabel.AutoSize = true;
            this.numberTitleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTitleLabel.ForeColor = System.Drawing.Color.White;
            this.numberTitleLabel.Location = new System.Drawing.Point(155, 66);
            this.numberTitleLabel.Name = "numberTitleLabel";
            this.numberTitleLabel.Size = new System.Drawing.Size(161, 23);
            this.numberTitleLabel.TabIndex = 5;
            this.numberTitleLabel.Text = "Number of guesses:";
            // 
            // numberOutput
            // 
            this.numberOutput.BackColor = System.Drawing.Color.DimGray;
            this.numberOutput.Location = new System.Drawing.Point(333, 55);
            this.numberOutput.Name = "numberOutput";
            this.numberOutput.Size = new System.Drawing.Size(36, 39);
            this.numberOutput.TabIndex = 6;
            // 
            // ResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.numberOutput);
            this.Controls.Add(this.numberTitleLabel);
            this.Controls.Add(this.originalTitleLabel);
            this.Controls.Add(this.sortedTitleLabel);
            this.Controls.Add(this.sortedLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "ResultsScreen";
            this.Size = new System.Drawing.Size(401, 369);
            this.Load += new System.EventHandler(this.ResultsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label sortedLabel;
        private System.Windows.Forms.Label sortedTitleLabel;
        private System.Windows.Forms.Label originalTitleLabel;
        private System.Windows.Forms.Label numberTitleLabel;
        private System.Windows.Forms.Label numberOutput;
    }
}
