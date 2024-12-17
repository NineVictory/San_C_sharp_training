ㄷnamespace Middle_Review
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("홍콩반점");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("짬뽕지존");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("차이나팩토리");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("중국집", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("스시로");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("쿠우쿠우");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("초밥집", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("김밥천국");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("할매순대국");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("분식+한식", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("빕스");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("아웃백");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("양식집", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Menu_tree_View = new System.Windows.Forms.TreeView();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.Btn_Random = new System.Windows.Forms.Button();
            this.Btn_Add_menu = new System.Windows.Forms.Button();
            this.Menu_txt_box = new System.Windows.Forms.TextBox();
            this.Restaurant_txt = new System.Windows.Forms.TextBox();
            this.btn_menu_board = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(806, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 12);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "시간\r\n";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(205, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(473, 396);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Menu_tree_View
            // 
            this.Menu_tree_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_tree_View.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Menu_tree_View.Location = new System.Drawing.Point(12, 51);
            this.Menu_tree_View.Name = "Menu_tree_View";
            treeNode1.Name = "Pack_jong_Won";
            treeNode1.Text = "홍콩반점";
            treeNode2.Name = "JjamBbong_Zz";
            treeNode2.Text = "짬뽕지존";
            treeNode3.Name = "China_factory";
            treeNode3.Text = "차이나팩토리";
            treeNode4.Name = "China_Food";
            treeNode4.Text = "중국집";
            treeNode5.Name = "Sushi_Ro";
            treeNode5.Text = "스시로";
            treeNode6.Name = "Kuukuu";
            treeNode6.Text = "쿠우쿠우";
            treeNode7.Name = "노드2";
            treeNode7.Text = "초밥집";
            treeNode8.Name = "Kimbab_Heaven";
            treeNode8.Text = "김밥천국";
            treeNode9.Name = "Grandma_Sundaeguk";
            treeNode9.Text = "할매순대국";
            treeNode10.Name = "노드3";
            treeNode10.Text = "분식+한식";
            treeNode11.Name = "Vips";
            treeNode11.Text = "빕스";
            treeNode12.Name = "Out_Back";
            treeNode12.Text = "아웃백";
            treeNode13.Name = "노드8";
            treeNode13.Text = "양식집";
            this.Menu_tree_View.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode10,
            treeNode13});
            this.Menu_tree_View.Size = new System.Drawing.Size(187, 434);
            this.Menu_tree_View.TabIndex = 2;
            this.Menu_tree_View.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_View_AfterSelect);
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(808, 107);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(62, 24);
            this.Btn_Add.TabIndex = 3;
            this.Btn_Add.Text = "매장추가";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(694, 173);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(176, 24);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "메뉴 삭제";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Location = new System.Drawing.Point(12, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(104, 30);
            this.title.TabIndex = 5;
            this.title.Text = "메뉴 추천";
            // 
            // Btn_Random
            // 
            this.Btn_Random.Location = new System.Drawing.Point(694, 48);
            this.Btn_Random.Name = "Btn_Random";
            this.Btn_Random.Size = new System.Drawing.Size(176, 24);
            this.Btn_Random.TabIndex = 6;
            this.Btn_Random.Text = "랜덤";
            this.Btn_Random.UseVisualStyleBackColor = true;
            this.Btn_Random.Click += new System.EventHandler(this.Btn_Random_Click);
            // 
            // Btn_Add_menu
            // 
            this.Btn_Add_menu.Location = new System.Drawing.Point(808, 78);
            this.Btn_Add_menu.Name = "Btn_Add_menu";
            this.Btn_Add_menu.Size = new System.Drawing.Size(62, 23);
            this.Btn_Add_menu.TabIndex = 7;
            this.Btn_Add_menu.Text = "종류추가";
            this.Btn_Add_menu.UseVisualStyleBackColor = true;
            this.Btn_Add_menu.Click += new System.EventHandler(this.Btn_Add_menu_Click);
            // 
            // Menu_txt_box
            // 
            this.Menu_txt_box.Location = new System.Drawing.Point(694, 78);
            this.Menu_txt_box.Name = "Menu_txt_box";
            this.Menu_txt_box.Size = new System.Drawing.Size(108, 21);
            this.Menu_txt_box.TabIndex = 8;
            // 
            // Restaurant_txt
            // 
            this.Restaurant_txt.Location = new System.Drawing.Point(694, 110);
            this.Restaurant_txt.Name = "Restaurant_txt";
            this.Restaurant_txt.Size = new System.Drawing.Size(108, 21);
            this.Restaurant_txt.TabIndex = 9;
            // 
            // btn_menu_board
            // 
            this.btn_menu_board.Location = new System.Drawing.Point(694, 144);
            this.btn_menu_board.Name = "btn_menu_board";
            this.btn_menu_board.Size = new System.Drawing.Size(176, 23);
            this.btn_menu_board.TabIndex = 10;
            this.btn_menu_board.Text = "메뉴판추가";
            this.btn_menu_board.UseVisualStyleBackColor = true;
            this.btn_menu_board.Click += new System.EventHandler(this.btn_menu_board_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 521);
            this.Controls.Add(this.btn_menu_board);
            this.Controls.Add(this.Restaurant_txt);
            this.Controls.Add(this.Menu_txt_box);
            this.Controls.Add(this.Btn_Add_menu);
            this.Controls.Add(this.Btn_Random);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Menu_tree_View);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "오늘 뭐먹지?";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TreeView Menu_tree_View;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button Btn_Random;
        private System.Windows.Forms.Button Btn_Add_menu;
        private System.Windows.Forms.TextBox Menu_txt_box;
        private System.Windows.Forms.TextBox Restaurant_txt;
        private System.Windows.Forms.Button btn_menu_board;
    }
}

