namespace Sum200
{
    partial class frmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHalfWay = new System.Windows.Forms.Label();
            this.txtHalfWay = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtTopValue = new System.Windows.Forms.TextBox();
            this.lblTopValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblHalfWay
            // 
            this.lblHalfWay.AutoSize = true;
            this.lblHalfWay.Location = new System.Drawing.Point(93, 88);
            this.lblHalfWay.Name = "lblHalfWay";
            this.lblHalfWay.Size = new System.Drawing.Size(72, 13);
            this.lblHalfWay.TabIndex = 1;
            this.lblHalfWay.Text = "Halfway Total";
            // 
            // txtHalfWay
            // 
            this.txtHalfWay.Location = new System.Drawing.Point(12, 85);
            this.txtHalfWay.Name = "txtHalfWay";
            this.txtHalfWay.ReadOnly = true;
            this.txtHalfWay.Size = new System.Drawing.Size(75, 20);
            this.txtHalfWay.TabIndex = 2;
            this.txtHalfWay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(12, 111);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(75, 20);
            this.txtSum.TabIndex = 4;
            this.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(93, 114);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(28, 13);
            this.lblSum.TabIndex = 3;
            this.lblSum.Text = "Sum";
            // 
            // txtTopValue
            // 
            this.txtTopValue.Location = new System.Drawing.Point(12, 41);
            this.txtTopValue.Name = "txtTopValue";
            this.txtTopValue.Size = new System.Drawing.Size(75, 20);
            this.txtTopValue.TabIndex = 6;
            this.txtTopValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTopValue
            // 
            this.lblTopValue.AutoSize = true;
            this.lblTopValue.Location = new System.Drawing.Point(93, 44);
            this.lblTopValue.Name = "lblTopValue";
            this.lblTopValue.Size = new System.Drawing.Size(56, 13);
            this.lblTopValue.TabIndex = 5;
            this.lblTopValue.Text = "Top Value";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 221);
            this.Controls.Add(this.txtTopValue);
            this.Controls.Add(this.lblTopValue);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtHalfWay);
            this.Controls.Add(this.lblHalfWay);
            this.Controls.Add(this.btnStart);
            this.Name = "frmMain";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHalfWay;
        private System.Windows.Forms.TextBox txtHalfWay;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtTopValue;
        private System.Windows.Forms.Label lblTopValue;
    }
}

