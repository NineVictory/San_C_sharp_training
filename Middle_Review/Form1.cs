using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Middle_Review
{

    public partial class Form1 : Form
    {
        int margin = 10;                                        // 화면 요소 간 여백을 설정하는 변수로 설정

        // 메뉴 이름과 이미지 경로를 매핑한 Dictionary 생성(key를 자식노드의 text값으로 value를 사진위치로 설정)
        private Dictionary<string, string> restaurantImages = new Dictionary<string, string>
        {
            { "홍콩반점", "../../images/hongkong.jpg" },
            { "짬뽕지존", "../../images/JjamBbong.jpg" },
            { "차이나팩토리", "../../images/China_factory.jpg" },
            { "스시로", "../../images/sushiro.jpg" },
            { "쿠우쿠우", "../../images/kuukuu.jpg" },
            { "김밥천국", "../../images/kimbab_heaven.png" },
            { "할매순대국", "../../images/grandma.png" },
            { "빕스", "../../images/vips.jpg" },
            { "아웃백", "../../images/outback.jpg" }
        };

        public Form1()                                          // Form1 클래스 생성자
        {
            InitializeComponent();                              // 폼 초기화
        }

        // Form1 로드 시 초기 설정
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = "";                                  // 시간 표시 초기화
            timer.Interval = 100;                              // 100ms마다 화면이 업데이트됨 (타이머 간격을 1초로 설정)
            timer.Tick += timer_Tick;                           // 타이머 Tick 이벤트에 핸들러 연결
            timer.Start();                                      // 타이머 시작

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;       // PictureBox 이미지 비율에 맞게 조정
            pictureBox.Image = Bitmap.FromFile("../../images/main_menu.jpg"); // 기본 이미지 로드
        }

        // 타이머 이벤트 핸들러
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Font = new Font("맑은 고딕", 10, FontStyle.Bold);         // 라벨 폰트 설정
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");         // 초 단위를 제외한 시간 포맷 설정
            lblTime.Location = new Point(ClientSize.Width - lblTime.Width - margin, margin); // 위치 설정(X축,Y축)으로 폼사이즈에서 레이블과 마진을 뺀 크기만큼이 X축

        }

        // TreeView 메뉴 선택 시 이미지 로드
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (restaurantImages.ContainsKey(e.Node.Text))                   // 선택한 메뉴가 Dictionary에 존재하는 경우
            {
                pictureBox.Image = Bitmap.FromFile(restaurantImages[e.Node.Text]); // 해당 이미지 로드
            }
        }

        // 랜덤 버튼 클릭 시 무작위 메뉴 이미지 표시
        private void Btn_Random_Click(object sender, EventArgs e)
        {
            Random rand = new Random();                                      // 랜덤 객체 생성
            List<string> keys = new List<string>(restaurantImages.Keys);     // Dictionary의 모든 키를 리스트로 변환
            string randomKey = keys[rand.Next(keys.Count)];                  // 랜덤으로 키 선택
            pictureBox.Image = Bitmap.FromFile(restaurantImages[randomKey]); // 선택된 이미지 표시
        }

        // 루트 메뉴 추가
        private void Btn_Add_menu_Click(object sender, EventArgs e)
        {
            string rootName = textBox1.Text;                                 // 텍스트 박스에서 입력된 값 가져오기

            if (!string.IsNullOrWhiteSpace(rootName))                        // 입력 값이 비어있지 않을 경우
            {
                treeView1.Nodes.Add(rootName);                               // 루트 노드 추가
                textBox1.Text = "";                                          // 입력 필드 초기화
            }
            else
            {
                MessageBox.Show("이름을 입력하세요!", "Error");               // 경고 메시지 표시
            }
        }


        // 선택된 루트 메뉴에 하위 메뉴 추가
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string InputValue = Restaurant_txt.Text;                        // 입력된 값 가져오기

            if (treeView1.SelectedNode != null && !string.IsNullOrWhiteSpace(InputValue)) // 선택된 노드와 입력 값 확인
            {
                treeView1.SelectedNode.Nodes.Add(InputValue);               // 선택된 노드에 자식 노드 추가
                treeView1.SelectedNode.Expand();                            // 새로 추가된 노드를 볼 수 있도록 확장
            }
            else
            {
                MessageBox.Show("이름을 입력하세요!", "Error");               // 경고 메시지 표시
            }
        }

        // 메뉴 이미지를 업데이트
        private void btn_menu_board_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();           // OpenFileDialog 객체 생성
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"; // 지원 파일 형식 필터 설정

            if (openFileDialog.ShowDialog() == DialogResult.OK)             // 파일 선택 확인
            {
                string selectedImagePath = openFileDialog.FileName;         // 선택된 파일 경로 가져오기

                if (treeView1.SelectedNode != null)                         // 선택된 TreeView 노드 확인
                {
                    if (treeView1.SelectedNode.Parent != null)              // 선택된 노드가 자식 노드인지 확인
                    {
                        string selectedNodeText = treeView1.SelectedNode.Text; // 선택된 노드의 텍스트 가져오기

                        if (restaurantImages.ContainsKey(selectedNodeText))  // 이미 존재하는 키인지 확인
                        {
                            restaurantImages[selectedNodeText] = selectedImagePath; // 이미지 경로 업데이트
                        }
                        else
                        {
                            restaurantImages.Add(selectedNodeText, selectedImagePath); // 새 키와 이미지 추가
                        }

                        pictureBox.Image = Bitmap.FromFile(selectedImagePath); // PictureBox에 새 이미지 표시
                        MessageBox.Show($"'{selectedNodeText}'의 이미지가 성공적으로 업데이트되었습니다!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information); // 성공 메시지 표시
                    }
                    else
                    {
                        MessageBox.Show("자식 노드를 선택해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error); // 경고 메시지 표시
                    }
                }
                else
                {
                    MessageBox.Show("노드를 선택해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error); // 경고 메시지 표시
                }
            }
        }

        // 선택된 노드 삭제
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)                             // 선택된 노드가 있는지 확인
            {
                DialogResult result = MessageBox.Show(
                    $"'{treeView1.SelectedNode.Text}' 노드를 삭제하시겠습니까?", // 삭제 확인 메시지
                    "삭제 확인",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)                             // 삭제 확인 시
                {
                    treeView1.Nodes.Remove(treeView1.SelectedNode);         // 선택된 노드 삭제
                }
            }
            else
            {
                MessageBox.Show("삭제할 노드를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error); // 경고 메시지 표시
            }
        }



    }
}
