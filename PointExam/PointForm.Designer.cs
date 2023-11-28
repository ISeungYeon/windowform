namespace PointExam
{
    partial class PointForm
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
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.lblPrint = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(179, 45);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(146, 25);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(179, 116);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(146, 25);
            this.txtY.TabIndex = 1;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(45, 48);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(31, 15);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X값";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(45, 119);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(30, 15);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y값";
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(133, 278);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(290, 25);
            this.txtPrint.TabIndex = 4;
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(31, 288);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(67, 15);
            this.lblPrint.TabIndex = 5;
            this.lblPrint.Text = "객체정보";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(48, 194);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "객체생성";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(157, 194);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "좌표변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(260, 194);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "이동";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // PointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 325);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "PointForm";
            this.Text = "Point";
            this.Load += new System.EventHandler(this.PointForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnMove;
    }
}

