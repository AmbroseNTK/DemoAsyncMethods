namespace DemoAsync
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
            this.tbN = new System.Windows.Forms.TextBox();
            this.numCore = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSum = new System.Windows.Forms.RadioButton();
            this.chkPrime = new System.Windows.Forms.RadioButton();
            this.chkMax = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCore)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(49, 12);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(128, 20);
            this.tbN.TabIndex = 3;
            // 
            // numCore
            // 
            this.numCore.Location = new System.Drawing.Point(239, 12);
            this.numCore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCore.Name = "numCore";
            this.numCore.Size = new System.Drawing.Size(65, 20);
            this.numCore.TabIndex = 4;
            this.numCore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(332, 10);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 5;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Task(s)";
            // 
            // chkSum
            // 
            this.chkSum.AutoSize = true;
            this.chkSum.Checked = true;
            this.chkSum.Location = new System.Drawing.Point(21, 23);
            this.chkSum.Name = "chkSum";
            this.chkSum.Size = new System.Drawing.Size(76, 17);
            this.chkSum.TabIndex = 7;
            this.chkSum.TabStop = true;
            this.chkSum.Text = "Tổng 1->N";
            this.chkSum.UseVisualStyleBackColor = true;
            // 
            // chkPrime
            // 
            this.chkPrime.AutoSize = true;
            this.chkPrime.Location = new System.Drawing.Point(21, 59);
            this.chkPrime.Name = "chkPrime";
            this.chkPrime.Size = new System.Drawing.Size(128, 17);
            this.chkPrime.TabIndex = 8;
            this.chkPrime.TabStop = true;
            this.chkPrime.Text = "Đếm số nguyên tố <N";
            this.chkPrime.UseVisualStyleBackColor = true;
            // 
            // chkMax
            // 
            this.chkMax.AutoSize = true;
            this.chkMax.Location = new System.Drawing.Point(21, 97);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(203, 17);
            this.chkMax.TabIndex = 9;
            this.chkMax.TabStop = true;
            this.chkMax.Text = "Tìm max của dãy số ngẫu nhiên dài N";
            this.chkMax.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "N:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMax);
            this.groupBox1.Controls.Add(this.chkSum);
            this.groupBox1.Controls.Add(this.chkPrime);
            this.groupBox1.Location = new System.Drawing.Point(28, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bài toán";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(268, 55);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(50, 13);
            this.lbResult.TabIndex = 12;
            this.lbResult.Text = "Kết quả: ";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(268, 73);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(54, 13);
            this.lbTime.TabIndex = 13;
            this.lbTime.Text = "Thời gian:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 186);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.numCore);
            this.Controls.Add(this.tbN);
            this.Name = "Form1";
            this.Text = "Demo MultiTask";
            ((System.ComponentModel.ISupportInitialize)(this.numCore)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.NumericUpDown numCore;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton chkSum;
        private System.Windows.Forms.RadioButton chkPrime;
        private System.Windows.Forms.RadioButton chkMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbTime;
    }
}

