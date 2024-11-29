using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A140
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("오스트리아, 빈");         //Items 속성은 목록에 표시할 개별 항목들의 컬렉션을 나타냄.
            listBox2.Items.Add("호주, 애들레이즈");
            listBox2.Items.Add("일본, 오사카");
            listBox2.Items.Add("대한민국, 서울");
            listBox2.Items.Add("캐나다, 캘거리");
            listBox2.Items.Add("호주, 시드니");
            listBox2.Items.Add("일본, 도쿄");
            listBox2.Items.Add("호주,애들레이드");

            //DataSource를 사용하면 대량의 데이터를 리스트에 쉽게 표시가능
            List<String> LstGDP = new List<string> { "미국", "러시아", "중국", "영국", "독일", "프랑스", "일본", "이스라엘", "사우디아라비아", "UAE" };
            listBox3.DataSource = LstGDP;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)  //이벤트 핸들러가 호출될 때 sender는 listBox1 컨트롤 객체가 됨.
        {
            ListBox lst = sender as ListBox;                //as 키워드: 특정 타입으로 형변환을 시도하는 연산자(성공하면 변환된 객체를 반환하고, 실패하면 null을 반환)
            txtIndex1.Text = lst.SelectedIndex.ToString();  //형변환시킨 listBox1에서 선택한 인덱스를txtIndex 텍스트에 넣는다.
            txtSItem1.Text = lst.SelectedItem.ToString();
        }
           
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txtIndex2.Text = lst.SelectedIndex.ToString();
            txtSItem2.Text = lst.SelectedItem.ToString();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            txtIndex3.Text = lst.SelectedIndex.ToString();
            txtSItem3.Text = lst.SelectedItem.ToString();
        }
    }
}
