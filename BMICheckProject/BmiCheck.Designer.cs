namespace BMICheckProject
{
    partial class BmiCheck
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
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblStandardWeight = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.lblObesity = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtStandardWeight = new System.Windows.Forms.TextBox();
            this.txtBmi = new System.Windows.Forms.TextBox();
            this.txtObesity = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(33, 27);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(22, 15);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "키";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(33, 97);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(52, 15);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "몸무게";
            // 
            // lblStandardWeight
            // 
            this.lblStandardWeight.AutoSize = true;
            this.lblStandardWeight.Location = new System.Drawing.Point(33, 236);
            this.lblStandardWeight.Name = "lblStandardWeight";
            this.lblStandardWeight.Size = new System.Drawing.Size(67, 15);
            this.lblStandardWeight.TabIndex = 2;
            this.lblStandardWeight.Text = "표준체중";
            this.lblStandardWeight.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBmi
            // 
            this.lblBmi.AutoSize = true;
            this.lblBmi.Location = new System.Drawing.Point(33, 320);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(104, 15);
            this.lblBmi.TabIndex = 3;
            this.lblBmi.Text = "비만지수(BMI)";
            // 
            // lblObesity
            // 
            this.lblObesity.AutoSize = true;
            this.lblObesity.Location = new System.Drawing.Point(33, 400);
            this.lblObesity.Name = "lblObesity";
            this.lblObesity.Size = new System.Drawing.Size(52, 15);
            this.lblObesity.TabIndex = 4;
            this.lblObesity.Text = "비만도";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(152, 27);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(140, 25);
            this.txtHeight.TabIndex = 5;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(152, 97);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(140, 25);
            this.txtWeight.TabIndex = 6;
            // 
            // txtStandardWeight
            // 
            this.txtStandardWeight.Location = new System.Drawing.Point(152, 236);
            this.txtStandardWeight.Name = "txtStandardWeight";
            this.txtStandardWeight.ReadOnly = true;
            this.txtStandardWeight.Size = new System.Drawing.Size(140, 25);
            this.txtStandardWeight.TabIndex = 7;
            // 
            // txtBmi
            // 
            this.txtBmi.Location = new System.Drawing.Point(152, 320);
            this.txtBmi.Name = "txtBmi";
            this.txtBmi.ReadOnly = true;
            this.txtBmi.Size = new System.Drawing.Size(140, 25);
            this.txtBmi.TabIndex = 8;
            // 
            // txtObesity
            // 
            this.txtObesity.Location = new System.Drawing.Point(152, 400);
            this.txtObesity.Name = "txtObesity";
            this.txtObesity.ReadOnly = true;
            this.txtObesity.Size = new System.Drawing.Size(140, 25);
            this.txtObesity.TabIndex = 9;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(183, 169);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "확인";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // BmiCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtObesity);
            this.Controls.Add(this.txtBmi);
            this.Controls.Add(this.txtStandardWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblObesity);
            this.Controls.Add(this.lblBmi);
            this.Controls.Add(this.lblStandardWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblHeight);
            this.Name = "BmiCheck";
            this.Text = "비만도 체크 프로그램";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblStandardWeight;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.Label lblObesity;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtStandardWeight;
        private System.Windows.Forms.TextBox txtBmi;
        private System.Windows.Forms.TextBox txtObesity;
        private System.Windows.Forms.Button btnRun;
    }
}

