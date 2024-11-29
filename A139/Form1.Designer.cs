namespace A139
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.srcR = new System.Windows.Forms.HScrollBar();
            this.srcG = new System.Windows.Forms.HScrollBar();
            this.srcB = new System.Windows.Forms.HScrollBar();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(136, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 177);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "red";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "blue";
            // 
            // srcR
            // 
            this.srcR.Location = new System.Drawing.Point(198, 287);
            this.srcR.Name = "srcR";
            this.srcR.Size = new System.Drawing.Size(372, 24);
            this.srcR.TabIndex = 4;
            this.srcR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.srcR_Scroll);
            // 
            // srcG
            // 
            this.srcG.Location = new System.Drawing.Point(198, 329);
            this.srcG.Name = "srcG";
            this.srcG.Size = new System.Drawing.Size(372, 24);
            this.srcG.TabIndex = 5;
            this.srcG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.srcR_Scroll);
            // 
            // srcB
            // 
            this.srcB.Location = new System.Drawing.Point(198, 369);
            this.srcB.Name = "srcB";
            this.srcB.Size = new System.Drawing.Size(372, 24);
            this.srcB.TabIndex = 6;
            this.srcB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.srcR_Scroll);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(603, 287);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 21);
            this.txtR.TabIndex = 7;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(603, 326);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 21);
            this.txtG.TabIndex = 8;
            this.txtG.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(603, 367);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 21);
            this.txtB.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.srcB);
            this.Controls.Add(this.srcG);
            this.Controls.Add(this.srcR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HScrollBar srcR;
        private System.Windows.Forms.HScrollBar srcG;
        private System.Windows.Forms.HScrollBar srcB;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
    }
}

