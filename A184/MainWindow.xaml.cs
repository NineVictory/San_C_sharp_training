using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace A184
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        // 색상을 표시할 Border 객체 리스트
        List<Border> borderList;

        // 1초마다 색상과 데이터를 갱신하기 위한 타이머
        DispatcherTimer t = new DispatcherTimer();

        // 랜덤 색상을 생성하기 위한 Random 객체
        Random r = new Random();

        // 데이터베이스 연결 문자열
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shkoo\source\repos\A184\Colors.mdf;Integrated Security=True";
        SqlConnection conn;

        public MainWindow()
        {
            InitializeComponent();

            // Border 객체 리스트를 초기화
            borderList = new List<Border>
           {border1, border2, border3, border4, border5,
            border6, border7, border8, border9, border10,
            border11, border12, border13, border14, border15,
            border16, border17, border18, border19, border20 };

            // 타이머 설정 (1초 간격)
            t.Interval = new TimeSpan(0, 0, 1);
            t.Tick += T_Tick; // 타이머 Tick 이벤트 핸들러 등록

        }
        private void T_Tick(object sender, EventArgs e)
        {
            // 현재 날짜와 시간 가져오기
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            lblDate.Text = "날짜 : " + date; // 날짜 표시
            string time = DateTime.Now.ToString("HH:mm:ss");
            lblTime.Text = "시간 : " + time; // 시간 표시

            // 20개의 랜덤 색상을 저장할 배열
            byte[] colors = new byte[20];
            for (int i = 0; i < 20; i++)
            {
                colors[i] = (byte)(r.Next(255)); // 0~255 범위의 랜덤 값 생성
                // Border 배경색 변경
                borderList[i].Background = new
                  SolidColorBrush(Color.FromRgb((byte)0, (byte)0, colors[i])); //SolidColorBrush: Color 객체를 브러시로 감싸 WPF 컨트롤의 배경이나 텍스트에 사용할 수 있는 형태로 만듬
                                                                               // Color.FromRgb : RGB(Red, Green, Blue) 값으로 색상을 생성
                                                                               //FromRgb 메서드는 byte 타입의 값을 요구하므로, 명시적으로 (byte)로 캐스팅
            }

            // 색상 데이터와 날짜, 시간을 데이터베이스에 삽입
            //INSERT INTO ColorTable VALUES (@date, @time, 23, 45, 67, ..., 123) 이런느낌으로 들어감.
            string sql = "INSERT INTO ColorTable VALUES (@date, @time";
            for (int i = 0; i < 20; i++)
            {
                sql += ", " + String.Format("{0}", colors[i]);                 
            }
            sql += ")";

            // 데이터베이스 연결 및 SQL 실행
            using (conn = new SqlConnection(connString))
            using (SqlCommand comm = new SqlCommand(sql, conn))
            {
                conn.Open(); // 데이터베이스 연결 열기
                comm.Parameters.AddWithValue("@date", date); // 날짜 파라미터 추가
                comm.Parameters.AddWithValue("@time", time); // 시간 파라미터 추가
                //colors[i]는 단순한 값 삽입: colors는 이미 배열에 랜덤 값으로 채워져 있고,
                //복잡한 데이터가 아니라 간단한 정수 값들이기 때문에 SQL 문자열에 바로 추가해도 문제가 없음
                comm.ExecuteNonQuery(); // SQL 실행
            }

            // 리스트박스에 삽입된 데이터를 추가
            string lstItem = "";
            lstItem += string.Format($"{date} {time} ");
            for (int i = 0; i < 20; i++)
            {
                lstItem += string.Format("{0,3} ", colors[i]);
            }
            lstDB.Items.Add(lstItem); // 리스트박스에 데이터 추가
        }
        bool flag = false; // 버튼 상태를 나타내는 플래그
        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            if (flag == false)
            {
                // 랜덤 표시 시작
                btnRandom.Content = "정지";
                t.Start(); // 타이머 시작
                flag = true;
            }
            else
            {
                // 랜덤 표시 중지
                btnRandom.Content = "Random 색깔 표시";
                t.Stop(); // 타이머 정지
                flag = false;
            }
        }

        private void btnDB_Click(object sender, RoutedEventArgs e)
        {
            // 리스트박스 초기화
            lstDB.Items.Clear();

            // 데이터베이스에서 모든 데이터 조회
            string sql = "SELECT * FROM ColorTable";
            int[] colors = new int[20];

            //using 키워드는 특정 리소스(예: 데이터베이스 연결, 파일 핸들러 등)를 사용한 후 자동으로 해제하기 위해 사용
            using (conn = new SqlConnection(connString)) //conn: 데이터베이스 연결 객체, connString은 연결 문자열.
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                conn.Open(); // 데이터베이스 연결 열기
                SqlDataReader reader = command.ExecuteReader(); // 데이터 조회용 명령 실행, 결과를 reader 객체에 저장

                int index = 0; // 리스트박스 인덱스 초기화
                while (reader.Read()) //데이터베이스에서 한 행씩 읽어옴.
                {
                    // 조회된 데이터를 라벨과 리스트박스에 출력
                    lblDate.Text = reader["Date"].ToString();
                    lblTime.Text = reader["Time"].ToString();
                    for (int i = 0; i < 20; i++)
                    {
                        colors[i] = int.Parse(reader[i + 3].ToString()); // i + 3은 테이블에서 색상 데이터가 네 번째 열부터 시작한다는 가정에 따라 사용
                    }

                    string record = ""; // 현재 레코드 문자열로 생성
                    for (int i = 0; i < reader.FieldCount; i++)  //reader.FieldCount: 현재 레코드에서 읽을 수 있는 필드(열)의 개수.
                        record += String.Format("{0,3}", reader[i].ToString()) + " ";  //record: 한 줄의 데이터(Date, Time, 색상 값들)를 문자열로 만듦.

                    lstDB.Items.Add(record); // 리스트박스에 데이터 추가
                    lstDB.SelectedIndex = index++; // 리스트박스에서 추가된 항목을 선택 상태로 표시.

                    // Border 배경색 업데이트(colors 배열의 색상 값으로 borderList의 각 배경색 변경)
                    for (int i = 0; i < 20; i++)
                    {
                        borderList[i].Background = new
                          SolidColorBrush(Color.FromRgb((byte)0, (byte)0, (byte)colors[i]));
                    }

                    // UI 갱신 및 20ms 지연
                    this.Dispatcher.Invoke((ThreadStart)(() => { }), DispatcherPriority.ApplicationIdle); //Dispatcher.Invoke: UI 업데이트 강제 실행.
                    Thread.Sleep(20); //UI에 반영되는 시각적 효과를 위해 20ms 지연.
                }
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close(); // 프로그램 종료
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            // 리스트박스 초기화
            lstDB.Items.Clear();

            // 데이터베이스에서 모든 데이터 삭제
            string sql = "Delete From ColorTable";

            using (conn = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                conn.Open(); // 데이터베이스 연결 열기
                // SQL 실행
                command.ExecuteNonQuery(); // DELETE 명령 실행, 영향을 받은 행 수 반환. (여기서는 반환값을 사용하지 않음))
            }
        }
    }
}