using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Form2가 실행 될때
        private void Form2_Load(object sender, EventArgs e)
        {
            // 콤보박스 데이터 공급
            List<string> posData = new List<string> { "사원", "대리", "과장", "차장", "부장" };
            cbPos.DataSource = posData;

            string[] cityData = { "서울", "대전", "대구", "부산", "광주" };
            cbCity.DataSource = cityData;

            // 데이터그리드뷰 데이터 공급
            List<User> users = new List<User>();
            users.Add(new User("a101", "김유신", "010-1234-1001", 25));
            users.Add(new User("a102", "김춘추", "010-1234-1002", 23));
            users.Add(new User("a103", "장보고", "010-1234-1003", 35));
            users.Add(new User("a104", "강감찬", "010-1234-1004", 45));
            users.Add(new User("a105", "이순신", "010-1234-1005", 55));

            gridView.DataSource = users;
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            lbPos.Text = "결과 : " + cbPos.Text;
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbCity.Text = "결과 : " + cbCity.SelectedText;
        }
    }
}
