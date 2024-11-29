using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace A160
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool newButton;    // 새로운 버튼이 눌렸는지 확인하는 변수
        private double savedValue; // 연산을 저장할 변수
        private char myOperator;   // 연산자(+,-,×,÷)를 저장할 변수

        public MainWindow()
        {
            InitializeComponent();   // 초기화 작업
        }

        // 숫자 버튼 클릭 시 텍스트박스에 숫자를 추가
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;       // 눌린 버튼을 Button 타입으로 변환
            string number = btn.Content.ToString(); // 버튼에 표시된 숫자 가져오기

            if (txtResult.Text == "0" || newButton == true) // 첫 번째 입력 또는 연산 후 새 입력 시
            {
                txtResult.Text = number;           // 텍스트박스에 숫자 표시
                newButton = false;                 // 새 버튼을 눌린 상태 해제
            }
            else
                txtResult.Text = txtResult.Text + number;  // 기존 텍스트 뒤에 숫자 추가
        }

        // 연산자 버튼 클릭 시 연산자와 현재 값을 저장
        private void btnOp_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;               // 눌린 버튼을 Button 타입으로 변환
            savedValue = double.Parse(txtResult.Text);   // 텍스트박스 값 저장
            myOperator = btn.Content.ToString()[0];      // 연산자 저장
            newButton = true;                            // 새로운 버튼 눌림 상태 설정
        }

        // 소수점 버튼 클릭 시 텍스트박스에 소수점 추가
        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.Contains(".") == false)   // 텍스트박스에 소수점이 없으면
                txtResult.Text += ".";                     // 소수점 추가
        }

        // '=' 버튼 클릭 시 계산 수행 후 결과 표시
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (myOperator == '+')                       // 덧셈 연산
                txtResult.Text = (savedValue + double.Parse(txtResult.Text)).ToString();
            else if (myOperator == '-')                  // 뺄셈 연산
                txtResult.Text = (savedValue - double.Parse(txtResult.Text)).ToString();
            else if (myOperator == '×')                  // 곱셈 연산
                txtResult.Text = (savedValue * double.Parse(txtResult.Text)).ToString();
            else if (myOperator == '÷')                  // 나눗셈 연산
                if (double.Parse(txtResult.Text) != 0)     // 0으로 나누는 경우 방지
                    txtResult.Text = (savedValue / double.Parse(txtResult.Text)).ToString();
                else
                    txtResult.Text = "Error";               // 0으로 나눴을 경우 에러 처리
        }
    }
}
