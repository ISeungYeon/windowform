namespace ColorPointProgram
{
    partial class ColorPointForm
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
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtXPrint = new System.Windows.Forms.TextBox();
            this.txtYPrint = new System.Windows.Forms.TextBox();
            this.txtZPrint = new System.Windows.Forms.TextBox();
            this.txtColorPrint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChangeX = new System.Windows.Forms.Button();
            this.btnChangeY = new System.Windows.Forms.Button();
            this.btnChangeZ = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(126, 51);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 25);
            this.txtX.TabIndex = 0;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(126, 111);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 25);
            this.txtY.TabIndex = 1;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(126, 167);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 25);
            this.txtZ.TabIndex = 2;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(126, 214);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 25);
            this.txtColor.TabIndex = 3;
            // 
            // txtXPrint
            // 
            this.txtXPrint.Location = new System.Drawing.Point(435, 51);
            this.txtXPrint.Name = "txtXPrint";
            this.txtXPrint.Size = new System.Drawing.Size(100, 25);
            this.txtXPrint.TabIndex = 4;
            // 
            // txtYPrint
            // 
            this.txtYPrint.Location = new System.Drawing.Point(435, 111);
            this.txtYPrint.Name = "txtYPrint";
            this.txtYPrint.Size = new System.Drawing.Size(100, 25);
            this.txtYPrint.TabIndex = 5;
            // 
            // txtZPrint
            // 
            this.txtZPrint.Location = new System.Drawing.Point(435, 167);
            this.txtZPrint.Name = "txtZPrint";
            this.txtZPrint.Size = new System.Drawing.Size(100, 25);
            this.txtZPrint.TabIndex = 6;
            // 
            // txtColorPrint
            // 
            this.txtColorPrint.Location = new System.Drawing.Point(435, 214);
            this.txtColorPrint.Name = "txtColorPrint";
            this.txtColorPrint.Size = new System.Drawing.Size(100, 25);
            this.txtColorPrint.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Z :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Y :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "X :";
            // 
            // btnChangeX
            // 
            this.btnChangeX.Location = new System.Drawing.Point(264, 54);
            this.btnChangeX.Name = "btnChangeX";
            this.btnChangeX.Size = new System.Drawing.Size(52, 22);
            this.btnChangeX.TabIndex = 13;
            this.btnChangeX.Text = ">>";
            this.btnChangeX.UseVisualStyleBackColor = true;
            this.btnChangeX.Click += new System.EventHandler(this.btnChangeX_Click);
            // 
            // btnChangeY
            // 
            this.btnChangeY.Location = new System.Drawing.Point(264, 111);
            this.btnChangeY.Name = "btnChangeY";
            this.btnChangeY.Size = new System.Drawing.Size(52, 22);
            this.btnChangeY.TabIndex = 13;
            this.btnChangeY.Text = ">>";
            this.btnChangeY.UseVisualStyleBackColor = true;
            this.btnChangeY.Click += new System.EventHandler(this.btnChangeY_Click);
            // 
            // btnChangeZ
            // 
            this.btnChangeZ.Location = new System.Drawing.Point(264, 170);
            this.btnChangeZ.Name = "btnChangeZ";
            this.btnChangeZ.Size = new System.Drawing.Size(52, 22);
            this.btnChangeZ.TabIndex = 13;
            this.btnChangeZ.Text = ">>";
            this.btnChangeZ.UseVisualStyleBackColor = true;
            this.btnChangeZ.Click += new System.EventHandler(this.btnChangeZ_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(264, 217);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(52, 22);
            this.btnChangeColor.TabIndex = 13;
            this.btnChangeColor.Text = ">>";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "좌표 생성 및 변경";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "현재 좌표 정보";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(66, 302);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 23);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "객체 생성";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(251, 302);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 15;
            this.btnChange.Text = "변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(450, 302);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 15;
            this.btnMove.Text = "이동";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // ColorPointFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 371);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.btnChangeZ);
            this.Controls.Add(this.btnChangeY);
            this.Controls.Add(this.btnChangeX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtColorPrint);
            this.Controls.Add(this.txtZPrint);
            this.Controls.Add(this.txtYPrint);
            this.Controls.Add(this.txtXPrint);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Name = "ColorPointFrom";
            this.Text = "3D Color Point";
            this.Load += new System.EventHandler(this.ColorPointFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtXPrint;
        private System.Windows.Forms.TextBox txtYPrint;
        private System.Windows.Forms.TextBox txtZPrint;
        private System.Windows.Forms.TextBox txtColorPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChangeX;
        private System.Windows.Forms.Button btnChangeY;
        private System.Windows.Forms.Button btnChangeZ;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnMove;
    }
}

