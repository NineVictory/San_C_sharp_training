namespace A171
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartView)).BeginInit();
            this.SuspendLayout();
            // 
            // chartView
            // 
            chartArea1.Name = "ChartArea1";
            this.chartView.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartView.Legends.Add(legend1);
            this.chartView.Location = new System.Drawing.Point(81, 26);
            this.chartView.Name = "chartView";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartView.Series.Add(series1);
            this.chartView.Size = new System.Drawing.Size(658, 300);
            this.chartView.TabIndex = 0;
            this.chartView.Text = "chart1";
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(220, 373);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(117, 23);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "합쳐서 그리기";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(450, 373);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(116, 23);
            this.btnTwo.TabIndex = 2;
            this.btnTwo.Text = "나누어서 그리기";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.chartView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartView;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
    }
}

