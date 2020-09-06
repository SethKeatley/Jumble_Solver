namespace WindowsFormsApp1
{
    partial class JumbleSolver
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
            this.txtNumLetters = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlLetters = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtNumLetters
            // 
            this.txtNumLetters.AcceptsReturn = true;
            this.txtNumLetters.Location = new System.Drawing.Point(277, 175);
            this.txtNumLetters.Name = "txtNumLetters";
            this.txtNumLetters.Size = new System.Drawing.Size(151, 26);
            this.txtNumLetters.TabIndex = 0;
            this.txtNumLetters.Text = "Number of Letters";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(309, 249);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(82, 34);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // pnlLetters
            // 
            this.pnlLetters.Location = new System.Drawing.Point(156, 113);
            this.pnlLetters.Name = "pnlLetters";
            this.pnlLetters.Size = new System.Drawing.Size(390, 130);
            this.pnlLetters.TabIndex = 2;
            // 
            // JumbleSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLetters);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtNumLetters);
            this.Name = "JumbleSolver";
            this.Text = "Jumble Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumLetters;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlLetters;
    }
}

