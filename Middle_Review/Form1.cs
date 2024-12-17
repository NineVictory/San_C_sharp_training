using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Middle_Review
{

    public partial class Form1 : Form
    {
        int margin = 10;                                                            // 화면 요소 간 여백을 설정하는 변수로 설정

        // 메뉴 이름과 이미지 경로를 매핑한 Dictionary 생성(key를 자식노드의 text값으로 value를 사진위치로 설정)
        private Dictionary<string, string> restaurant_Images = new Dictionary<string, string>
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

        public Form1()                                                              // Form1 클래스 생성자
        {
            InitializeComponent();                                                  // 폼 초기화
        }

        // Form1 로드 시 초기 설정
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = "";                                                      // 시간 표시 초기화
            timer.Interval = 100;                                                   // 100ms마다 화면이 업데이트됨 (타이머 간격을 1초로 설정)
            timer.Tick += timer_Tick;                                               // 타이머 Tick 이벤트에 핸들러 연결
            timer.Start();                                                          // 타이머 시작

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;                          // PictureBox 이미지 비율에 맞게 조정
            pictureBox.Image = Bitmap.FromFile("../../images/main_menu.jpg");       // 기본 이미지 로드

        }

        // 타이머 이벤트 핸들러
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Font = new Font("맑은 고딕", 10, FontStyle.Bold);                // 라벨 폰트 설정
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");               // 초 단위를 제외한 시간 포맷 설정
            lblTime.Location = new Point(ClientSize.Width - lblTime.Width - margin, margin); // 위치 설정(X축,Y축)으로 폼사이즈에서 레이블과 마진을 뺀 크기만큼이 X축
        }

        // TreeView 메뉴 선택 시 이미지 로드
        //AfterSelect 는 트리뷰에서 선택한 항목이 변경되면 실행되는 동작
        private void tree_View_AfterSelect(object sender, TreeViewEventArgs e)      //선택된 항목과 관련된 정보가 TreeViewEventArgs 객체에 저장되어 전달
        {   
            if (restaurant_Images.ContainsKey(e.Node.Text))                         // 선택한 메뉴가 Dictionary에 존재하는 경우
            {
                pictureBox.Image = Bitmap.FromFile(restaurant_Images[e.Node.Text]); // 해당 이미지 로드(e.Node.Text가 키값이기 때문에 키값에 맞는 value값이 반환된다)
            }
        }

        // 랜덤 버튼 클릭 시 무작위 메뉴 이미지 표시
        private void Btn_Random_Click(object sender, EventArgs e)
        {
            Random rand = new Random();                                             // 랜덤 객체 생성
            List<string> keys = new List<string>(restaurant_Images.Keys);           // Dictionary의 모든 키를 리스트로 변환
            string random_Key = keys[rand.Next(keys.Count)];                        // 랜덤으로 키 선택(0부터 keys.Count - 1 사이의 정수를 랜덤으로 생성)
            pictureBox.Image = Bitmap.FromFile(restaurant_Images[random_Key]);      // 선택된 이미지 표시
        }

        // 루트 메뉴 추가
        private void Btn_Add_menu_Click(object sender, EventArgs e)
        {
            string input_val_menu = Menu_txt_box.Text;                               // 텍스트 박스에서 입력된 값 가져오기

            if (!string.IsNullOrWhiteSpace(input_val_menu))                          // 입력 값이 null, 빈 문자열(""), 또는 공백으로만 구성된 경우 true를 반환
            {
                Menu_tree_View.Nodes.Add(input_val_menu);                            // 루트 노드 추가(트리뷰의 루트노드 컬렉션인 Menu_tree_View.Nodes에 입력값을 추가한다)
                Menu_txt_box.Text = "";                                              // 입력 필드 초기화(추가가 되면 새로 입력할 수 있도록 기존값을 삭제)
            }
            else
            {
                MessageBox.Show("음식종류를 입력하세요!", "Error");                     // 경고 메시지 표시
            }
        }


        // 선택된 루트 메뉴에 하위 메뉴 추가
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string input_value_rest = Restaurant_txt.Text;                            // 입력된 값 가져오기
            //SelectedNode로 트리뷰에서 선택을 했는지 여부 && 입력을 했는지 여부
            if (Menu_tree_View.SelectedNode != null && !string.IsNullOrWhiteSpace(input_value_rest)) // 선택된 노드와 입력 값 확인
            {
                Menu_tree_View.SelectedNode.Nodes.Add(input_value_rest);               // 선택된 노드에 자식 노드 추가
                Menu_tree_View.SelectedNode.Expand();                                  // 새로 추가된 노드를 볼 수 있도록 확장
                                                                                       // (Expand는 선택된 노드가 접혀 있는 경우 펼치게해줌)
            }
            else
            {
                MessageBox.Show("음식점 이름을 입력하지 않았거나 음식종류를 선택하지 않았습니다!", "Error");                     // 경고 메시지 표시
            }
        }

        // 메뉴 이미지를 업데이트
        private void btn_menu_board_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();                       // OpenFileDialog:파일을 선택할 수 있도록 파일 탐색 창을 띄우는 객체
                                                                                        // 파일을 선택하고 확인을 누르면 파일의 경로를 가질 수 있음
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";             // 지원 파일 형식 필터 설정
                                                                                        // 제목 | 지원 파일 형식을 입력해줌.
                    
            if (openFileDialog.ShowDialog() == DialogResult.OK)                         // 파일 선택 후 확인버튼을 클릭 했을 경우 조건문 실행
            {
                string selected_Image_Path = openFileDialog.FileName;                   // 선택된 파일 경로 가져오기

                if (Menu_tree_View.SelectedNode != null)                                // 현재 트리뷰에서 선택된 노드 확인 여부
                {
                    if (Menu_tree_View.SelectedNode.Parent != null)                     // 선택된 노드가 자식 노드인지 확인
                                                                                        // null인경우 부모노드가 없는 것이므로 선택한 노드가 루트노트임을 알 수 있음
                    {
                        string selected_Node_Text = Menu_tree_View.SelectedNode.Text;   // 선택된 노드의 텍스트 가져오기

                        if (restaurant_Images.ContainsKey(selected_Node_Text))          // 이미 존재하는 키인지 확인
                        {
                            restaurant_Images[selected_Node_Text] = selected_Image_Path; // 이미지 경로 업데이트
                        }
                        else
                        {
                            restaurant_Images.Add(selected_Node_Text, selected_Image_Path); // 새 키와 이미지 추가
                        }

                        pictureBox.Image = Bitmap.FromFile(selected_Image_Path);        // PictureBox에 새 이미지 표시
                        MessageBox.Show($"'{selected_Node_Text}'의 메뉴판이 성공적으로 등록되었습니다!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information); // 성공 메시지 표시
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
            if (Menu_tree_View.SelectedNode != null)                                    // 선택된 노드가 있는지 확인
            {
                DialogResult result = MessageBox.Show
                (
                    $"'{Menu_tree_View.SelectedNode.Text}' 노드를 삭제하시겠습니까?",      // 삭제 확인 메시지
                    "삭제 확인",    
                    MessageBoxButtons.YesNo,                                            //예 ,아니오 버튼
                    MessageBoxIcon.Warning                                              //노란색 삼각형의 느낌표가 있는 Warning 아이콘
                );

                if (result == DialogResult.Yes)                                         // 삭제 확인 시
                {
                    Menu_tree_View.Nodes.Remove(Menu_tree_View.SelectedNode);           // 선택된 노드 삭제
                }
            }
            else
            {
                MessageBox.Show("삭제할 노드를 선택하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error); // 경고 메시지 표시
            }
        }
    }
}
   