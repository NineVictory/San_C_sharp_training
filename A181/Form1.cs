using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // OleDb를 통해 Access 데이터베이스에 연결
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Windows Forms 관련 기능 사용

namespace A181
{
    public partial class Form1 : Form
    {
        // OleDb 연결 객체 선언
        OleDbConnection conn = null; // 데이터베이스 연결 객체
        OleDbCommand comm = null;    // SQL 명령 실행 객체
        OleDbDataReader reader = null; // 데이터 읽기 객체

        // 데이터베이스 연결 문자열 (Access .accdb 파일 경로 설정)
        string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;
                        Data Source=C:\Users\shkoo\source\repos\A181\studentTable1.accdb";

        public Form1()
        {
            InitializeComponent(); // Windows Form 초기화
            DisplayStudents();    // 초기화 시 학생 데이터 표시
        }

        // 학생 데이터를 listBox1에 표시
        private void DisplayStudents()
        {
            ConnectionOpen(); // 데이터베이스 연결 열기

            // 학생 테이블에서 모든 데이터를 가져오는 SQL 명령어
            string sql = "SELECT * FROM studentTable1";

            // SQL 명령어 객체 초기화
            comm = new OleDbCommand(sql, conn);

            // 데이터를 읽어서 리스트 박스에 추가
            ReadAndAddToListBox();

            ConnectionClose(); // 데이터베이스 연결 닫기
        }

        // 데이터를 읽고 리스트 박스에 추가하는 함수
        private void ReadAndAddToListBox()
        {
            reader = comm.ExecuteReader(); // SQL 명령 실행 결과 읽기 (ExecuteReader는 주로 select문에서만 사용)
            while (reader.Read()) // 데이터가 있을 때까지 반복
            {
                string x = ""; // 학생 데이터를 저장할 문자열
                x += reader["ID"] + "\t";     // ID 필드 추가
                x += reader["SId"] + "\t";    // 학생 번호 추가
                x += reader["SName"] + "\t";  // 학생 이름 추가
                x += reader["Phone"];         // 전화번호 추가

                listBox1.Items.Add(x); // 리스트 박스에 데이터 추가
            }
            reader.Close(); // 리더 닫기
        }

        // 리스트 박스에서 선택한 항목의 데이터를 텍스트 박스로 표시
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox; // 이벤트 발생한 리스트 박스 객체

            if (lb.SelectedItem == null) // 선택한 항목이 없으면 종료
                return;

            // 탭 문자로 나눠 데이터를 분리
            string[] s = lb.SelectedItem.ToString().Split('\t');
            txtsId.Text = s[0];    // ID 필드
            txtsId.Text = s[1];    // 학생 번호
            txtsName.Text = s[2];  // 학생 이름
            txtsPhone.Text = s[3]; // 전화번호
        }

        // 새 학생 데이터를 추가하는 버튼 이벤트
        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 필수 입력 필드가 비어 있으면 종료
            if (txtsName.Text == "" || txtsPhone.Text == "" || txtsId.Text == "")
                return;

            ConnectionOpen(); // 데이터베이스 연결 열기

            // INSERT SQL 명령어 작성
            string sql = string.Format("insert into studentTable1(SId, SName, Phone) " +
              "VALUES({0}, '{1}', '{2}')", txtsId.Text, txtsName.Text, txtsPhone.Text);
            MessageBox.Show(sql); // SQL 명령어 출력 (디버깅용)

            comm = new OleDbCommand(sql, conn); // SQL 명령 실행 객체 초기화
            int x = comm.ExecuteNonQuery();    // SQL 실행(ExecuteNonQuery는 반환값이 정수(int)이다.
                                               // insert문으로 1개의 데이터를 넣었으니 1이 return이됨)
            if (x == 1)                        // 실행 결과가 성공적이면
                MessageBox.Show("삽입 성공!");

            ConnectionClose(); // 연결 닫기

            listBox1.Items.Clear(); // 리스트 박스 초기화
            DisplayStudents();      // 업데이트된 학생 데이터 표시
        }

        // 텍스트 박스 내용을 초기화하는 버튼 이벤트
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsId.Text = "";    // ID 텍스트 박스 초기화
            txtsName.Text = "";  // 이름 텍스트 박스 초기화
            txtsPhone.Text = ""; // 전화번호 텍스트 박스 초기화
            txtsId.Text = "";    // 학생 번호 초기화
        }

        // 모든 학생 데이터를 다시 표시하는 버튼 이벤트
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // 리스트 박스 초기화
            DisplayStudents();      // 모든 데이터 표시
        }

        // 프로그램 종료 버튼 이벤트
        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close(); // 폼 닫기
        }

        // 학생 데이터를 검색하는 버튼 이벤트
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 적어도 하나의 검색 조건이 있어야 함
            if (txtsId.Text == "" && txtsName.Text == "" && txtsPhone.Text == "" && txtsId.Text == "")
                return;

            ConnectionOpen(); // 데이터베이스 연결 열기

            string sql = ""; // SQL 명령 초기화

            // 검색 조건에 따라 SQL 작성
            if (txtsId.Text != "")
                sql = string.Format("SELECT * FROM studentTable1 WHERE SId={0}", txtsId.Text);
            else if (txtsName.Text != "")
                sql = string.Format("SELECT * FROM studentTable1 WHERE SName='{0}'", txtsName.Text);
            else if (txtsPhone.Text != "")
                sql = string.Format("SELECT * FROM studentTable1 WHERE Phone='{0}'", txtsPhone.Text);

            MessageBox.Show(sql); // SQL 명령어 출력 (디버깅용)
            listBox1.Items.Clear(); // 리스트 박스 초기화

            comm = new OleDbCommand(sql, conn); // SQL 명령 실행 객체 초기화

            ReadAndAddToListBox(); // 결과 읽어서 리스트 박스에 추가
            ConnectionClose();     // 연결 닫기
        }

        // 학생 데이터를 수정하는 버튼 이벤트
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ConnectionOpen(); // 데이터베이스 연결 열기

            // UPDATE SQL 명령 작성
            string sql = string.Format("UPDATE studentTable1 SET SId={0}, SName='{1}', Phone='{2}' WHERE ID={3}",
              txtsId.Text, txtsName.Text, txtsPhone.Text, txtsId.Text);
            MessageBox.Show(sql); // SQL 명령 출력 (디버깅용)

            comm = new OleDbCommand(sql, conn); // SQL 명령 실행 객체 초기화
            if (comm.ExecuteNonQuery() == 1)    // SQL 실행 결과 성공 확인
                MessageBox.Show("수정 성공!");

            ConnectionClose(); // 연결 닫기

            listBox1.Items.Clear(); // 리스트 박스 초기화
            DisplayStudents();      // 업데이트된 데이터 표시
        }

        // 학생 데이터를 삭제하는 버튼 이벤트
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ConnectionOpen(); // 데이터베이스 연결 열기

            // DELETE SQL 명령 작성
            string sql = string.Format("DELETE FROM studentTable1 WHERE ID={0}", txtsId.Text);
            MessageBox.Show(sql); // SQL 명령 출력 (디버깅용)

            comm = new OleDbCommand(sql, conn); // SQL 명령 실행 객체 초기화
            if (comm.ExecuteNonQuery() == 1)    // SQL 실행 결과 성공 확인
                MessageBox.Show("삭제 성공!");

            ConnectionClose(); // 연결 닫기
            listBox1.Items.Clear(); // 리스트 박스 초기화
            DisplayStudents();      // 업데이트된 데이터 표시
        }

        // 데이터베이스 연결 열기
        private void ConnectionOpen()
        {
            if (conn == null) // 연결 객체가 초기화되지 않았다면
            {
                conn = new OleDbConnection(connStr); // 연결 객체 초기화
                conn.Open(); // 연결 열기
            }
        }

        // 데이터베이스 연결 닫기
        private void ConnectionClose()
        {
            conn.Close(); // 연결 닫기
            conn = null;  // 연결 객체 초기화
        }
    }
}
