using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A150
{
    public partial class Form1 : Form
    {
        //private Timer myTimer = new Timer();
        private DateTime dDay;                                      //알람날짜
        private DateTime tTime;                                     //알람시간
        private bool setAlarm;                                      //알람을 설정하면 true
        public Form1()
        {
            InitializeComponent();

            lblAlarm.ForeColor = Color.Gray;
            lblAlarmSet.ForeColor = Color.Gray;

            timePicker.Format = DateTimePickerFormat.Custom;        //사용자가 직접 커스텀한 시간/날짜 형식을 사용
            timePicker.CustomFormat = "tt hh:mm";                   //직접 커스텀한 내용

            myTimer.Interval = 1000;
            myTimer.Tick += myTimer_Tick;                           //1000m/s 즉 1초마다 myTimer.Tick메서드를 호출한다.
            myTimer.Start();
        }



        private void myTimer_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;                          //cTime : 현재시간
            lblDate.Text = cTime.ToShortDateString();               //현재 날짜를 간단한 형식의 문자열로 반환
            lblTime.Text = cTime.ToLongTimeString();                //현재 시간을 시:분:초 형식의 문자열로 반환

            if (setAlarm == true)
            {   
                //알람시간과 현재시간이 일치하다면 알람을 끄고(false) 메시지 박스를 호출한다.
                if(dDay == DateTime.Today && cTime.Hour == tTime.Hour && cTime.Minute == tTime.Minute)
                {
                    setAlarm = false;
                    MessageBox.Show("wake up");
                }  
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            dDay = DateTime.Parse(datePicker.Text);
            tTime = DateTime.Parse(timePicker.Text); 
            
            setAlarm = true;
            lblAlarmSet.ForeColor= Color.Red;
            lblAlarm.ForeColor= Color.Blue;
            lblAlarm.Text = "Alarm :" + dDay.ToShortDateString() + " " + tTime.ToLongTimeString();
            tabControl1.SelectedTab = tabPage2;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setAlarm = false;
            lblAlarmSet.ForeColor = Color.Green;
            lblAlarm.ForeColor = Color.Green;
            lblAlarm.Text = "Alarm :";
            tabControl1.SelectedTab = tabPage2;
        }
    }
}
