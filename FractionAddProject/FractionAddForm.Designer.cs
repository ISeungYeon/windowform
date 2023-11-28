namespace FractionAddProject
{
    partial class FractionAddForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumerator1 = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDenominator1 = new System.Windows.Forms.TextBox();
            this.txtDenominator2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumerator2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDenominator3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumerator3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "분수1";
            // 
            // txtNumerator1
            // 
            this.txtNumerator1.Location = new System.Drawing.Point(251, 38);
            this.txtNumerator1.Name = "txtNumerator1";
            this.txtNumerator1.Size = new System.Drawing.Size(100, 25);
            this.txtNumerator1.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(69, 206);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(88, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "=";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "분자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "분모";
            // 
            // txtDenominator1
            // 
            this.txtDenominator1.Location = new System.Drawing.Point(251, 89);
            this.txtDenominator1.Name = "txtDenominator1";
            this.txtDenominator1.Size = new System.Drawing.Size(100, 25);
            this.txtDenominator1.TabIndex = 5;
            // 
            // txtDenominator2
            // 
            this.txtDenominator2.Location = new System.Drawing.Point(628, 92);
            this.txtDenominator2.Name = "txtDenominator2";
            this.txtDenominator2.Size = new System.Drawing.Size(100, 25);
            this.txtDenominator2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "분모";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "분자";
            // 
            // txtNumerator2
            // 
            this.txtNumerator2.Location = new System.Drawing.Point(628, 41);
            this.txtNumerator2.Name = "txtNumerator2";
            this.txtNumerator2.Size = new System.Drawing.Size(100, 25);
            this.txtNumerator2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "+";
            // 
            // txtDenominator3
            // 
            this.txtDenominator3.Location = new System.Drawing.Point(439, 238);
            this.txtDenominator3.Name = "txtDenominator3";
            this.txtDenominator3.Size = new System.Drawing.Size(100, 25);
            this.txtDenominator3.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "분모";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "분자";
            // 
            // txtNumerator3
            // 
            this.txtNumerator3.Location = new System.Drawing.Point(439, 187);
            this.txtNumerator3.Name = "txtNumerator3";
            this.txtNumerator3.Size = new System.Drawing.Size(100, 25);
            this.txtNumerator3.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "결과";
            // 
            // FractionAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.txtDenominator3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumerator3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDenominator2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumerator2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDenominator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtNumerator1);
            this.Controls.Add(this.label1);
            this.Name = "FractionAddForm";
            this.Text = "분수 계산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumerator1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDenominator1;
        private System.Windows.Forms.TextBox txtDenominator2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumerator2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDenominator3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumerator3;
        private System.Windows.Forms.Label label9;
    }
}

