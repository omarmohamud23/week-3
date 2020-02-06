namespace week_3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.btnWhatStatus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Credits";
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(148, 13);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(72, 20);
            this.txtCredits.TabIndex = 1;
            // 
            // btnWhatStatus
            // 
            this.btnWhatStatus.Location = new System.Drawing.Point(109, 54);
            this.btnWhatStatus.Name = "btnWhatStatus";
            this.btnWhatStatus.Size = new System.Drawing.Size(111, 23);
            this.btnWhatStatus.TabIndex = 2;
            this.btnWhatStatus.Text = "Whats my status?";
            this.btnWhatStatus.UseVisualStyleBackColor = true;
            this.btnWhatStatus.Click += new System.EventHandler(this.btnWhatStatus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(106, 98);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status shown here ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 170);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnWhatStatus);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Button btnWhatStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}

