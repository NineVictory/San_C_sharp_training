namespace A138
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
            this.Date2_1 = new System.Windows.Forms.MaskedTextBox();
            this.Adress1 = new System.Windows.Forms.MaskedTextBox();
            this.Phone1 = new System.Windows.Forms.MaskedTextBox();
            this.Id1 = new System.Windows.Forms.MaskedTextBox();
            this.Email1 = new System.Windows.Forms.MaskedTextBox();
            this.Date = new System.Windows.Forms.Label();
            this.Date2 = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Date1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Date2_1
            // 
            this.Date2_1.Location = new System.Drawing.Point(242, 181);
            this.Date2_1.Mask = "000-000";
            this.Date2_1.Name = "Date2_1";
            this.Date2_1.Size = new System.Drawing.Size(100, 21);
            this.Date2_1.TabIndex = 1;
            // 
            // Adress1
            // 
            this.Adress1.Location = new System.Drawing.Point(242, 208);
            this.Adress1.Name = "Adress1";
            this.Adress1.Size = new System.Drawing.Size(290, 21);
            this.Adress1.TabIndex = 2;
            // 
            // Phone1
            // 
            this.Phone1.Location = new System.Drawing.Point(242, 235);
            this.Phone1.Mask = "000-9000-0000";
            this.Phone1.Name = "Phone1";
            this.Phone1.Size = new System.Drawing.Size(100, 21);
            this.Phone1.TabIndex = 3;
            // 
            // Id1
            // 
            this.Id1.Location = new System.Drawing.Point(242, 262);
            this.Id1.Mask = "000000-0000000";
            this.Id1.Name = "Id1";
            this.Id1.Size = new System.Drawing.Size(100, 21);
            this.Id1.TabIndex = 4;
            // 
            // Email1
            // 
            this.Email1.Location = new System.Drawing.Point(242, 289);
            this.Email1.Name = "Email1";
            this.Email1.Size = new System.Drawing.Size(290, 21);
            this.Email1.TabIndex = 5;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(187, 157);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(41, 12);
            this.Date.TabIndex = 6;
            this.Date.Text = "입사일";
            // 
            // Date2
            // 
            this.Date2.AutoSize = true;
            this.Date2.Location = new System.Drawing.Point(187, 184);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(53, 12);
            this.Date2.TabIndex = 7;
            this.Date2.Text = "우편번호";
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(196, 211);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(29, 12);
            this.Adress.TabIndex = 8;
            this.Adress.Text = "주소";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(171, 238);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(65, 12);
            this.Phone.TabIndex = 9;
            this.Phone.Text = "휴대폰번호";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(159, 265);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(77, 12);
            this.Id.TabIndex = 10;
            this.Id.Text = "주민등록번호";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(187, 292);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 12);
            this.Email.TabIndex = 11;
            this.Email.Text = "이메일";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Date1
            // 
            this.Date1.Location = new System.Drawing.Point(242, 154);
            this.Date1.Mask = "0000년 90월 90일";
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(100, 21);
            this.Date1.TabIndex = 0;
            this.Date1.ValidatingType = typeof(System.DateTime);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.Date2);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Email1);
            this.Controls.Add(this.Id1);
            this.Controls.Add(this.Phone1);
            this.Controls.Add(this.Adress1);
            this.Controls.Add(this.Date2_1);
            this.Controls.Add(this.Date1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox Date2_1;
        private System.Windows.Forms.MaskedTextBox Adress1;
        private System.Windows.Forms.MaskedTextBox Phone1;
        private System.Windows.Forms.MaskedTextBox Id1;
        private System.Windows.Forms.MaskedTextBox Email1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Date2;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox Date1;
    }
}

