namespace compound_interest
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
            this.principalTB = new System.Windows.Forms.TextBox();
            this.principalLBL = new System.Windows.Forms.Label();
            this.calcBTN = new System.Windows.Forms.Button();
            this.resultsTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // principalTB
            // 
            this.principalTB.Location = new System.Drawing.Point(68, 40);
            this.principalTB.Name = "principalTB";
            this.principalTB.Size = new System.Drawing.Size(100, 20);
            this.principalTB.TabIndex = 0;
            // 
            // principalLBL
            // 
            this.principalLBL.AutoSize = true;
            this.principalLBL.Location = new System.Drawing.Point(12, 43);
            this.principalLBL.Name = "principalLBL";
            this.principalLBL.Size = new System.Drawing.Size(50, 13);
            this.principalLBL.TabIndex = 1;
            this.principalLBL.Text = "Principal:";
            // 
            // calcBTN
            // 
            this.calcBTN.Location = new System.Drawing.Point(248, 36);
            this.calcBTN.Name = "calcBTN";
            this.calcBTN.Size = new System.Drawing.Size(75, 23);
            this.calcBTN.TabIndex = 2;
            this.calcBTN.Text = "Calculate";
            this.calcBTN.UseVisualStyleBackColor = true;
            this.calcBTN.Click += new System.EventHandler(this.calcBTN_Click);
            // 
            // resultsTB
            // 
            this.resultsTB.Location = new System.Drawing.Point(15, 93);
            this.resultsTB.Multiline = true;
            this.resultsTB.Name = "resultsTB";
            this.resultsTB.ReadOnly = true;
            this.resultsTB.Size = new System.Drawing.Size(345, 180);
            this.resultsTB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 285);
            this.Controls.Add(this.resultsTB);
            this.Controls.Add(this.calcBTN);
            this.Controls.Add(this.principalLBL);
            this.Controls.Add(this.principalTB);
            this.Name = "Form1";
            this.Text = "Compound Interest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principalTB;
        private System.Windows.Forms.Label principalLBL;
        private System.Windows.Forms.Button calcBTN;
        private System.Windows.Forms.TextBox resultsTB;
    }
}

