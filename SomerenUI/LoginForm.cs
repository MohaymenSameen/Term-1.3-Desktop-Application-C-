using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SomerenUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            showPanel("Login");
        }

        private void pnl_Login_Paint(object sender, PaintEventArgs e)
        {

        }
        private void showPanel(string panelName)
        {
            try
            {
                if(panelName=="Login")
                {

                }

            }
            catch
            {

            }
        }
        //login
       // string[] usernames = {  "piet@infhaarlem.nl", "rita @ infhaarlem.nl" };
        //string[] passwords = {  "t78Dx4BfhqfEamxdnAkLCpbC", "qd6VqFfyzF5UgPRDNy9NSCb4" };
        private void Login_Click(object sender, EventArgs e)
        {
            Login_Service loginService = new Login_Service();
            List<LoginData> loginDatas = loginService.GetLoginDatas();
            foreach (var lg in loginDatas)
            {

                if (lg.Username == UsernameBox.Text && lg.Password == PasswordBox.Text)
                {
                    SomerenUI s = new SomerenUI();
                    s.ShowDialog();
                    this.Hide();
                }
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {

        }

        private void button_Forgot_Click(object sender, EventArgs e)
        {
            //Forgot password window form (recover.cs)
            var myForm = new Recover();
            myForm.Show();           

        }
    }
}
