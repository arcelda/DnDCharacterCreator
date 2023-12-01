using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharacterCreator
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string filepath = "Logins.txt";

            LoginHandler logins = new LoginHandler(textBox_Password.Text, textBox_Username.Text);

            logins.FilePath = filepath;

            if (logins.Check())
            {
                FormReturningPlayer formReturningPlayer = new FormReturningPlayer();
                this.Hide();
                formReturningPlayer.ShowDialog();
            }
            
            else
            {
                MessageBox.Show(logins.Error, "Error");
                ResetForm();
            }

        }

        private void ResetForm()
        {
            textBox_Username.Clear();
            textBox_Password.Clear();
            textBox_Username.Focus();
        }
    }
}
