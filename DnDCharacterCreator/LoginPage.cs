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
                formReturningPlayer.name = textBox_Username.Text;
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

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the form?", "Dnd Character Creator",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form1 form = new Form1();
                form.ShowDialog();
            }
        }
    }
}
