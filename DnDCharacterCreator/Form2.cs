using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCharacterCreator
{
    public partial class FormReturningPlayer : Form
    {
        public FormReturningPlayer()
        {
            InitializeComponent();
        }

        public string name;

        private void buttonHome_Click(object sender, EventArgs e)
        {
            DialogResult exitYN = MessageBox.Show("Are you sure you want to exit", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           
            if(exitYN == DialogResult.Yes)
            {
                ResetPage();
                this.Close();
                Form1 form = new Form1();
                form.Show();
            }
                
        }

        private void searchPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPlayer searchPlayer = new SearchPlayer();
            searchPlayer.ShowDialog();
        }

        private void searchSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchSession searchSession = new SearchSession();
            searchSession.ShowDialog();
        }

        private void FormReturningPlayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnd_DatabaseDataSet1.CharacterTable' table. You can move, or remove it, as needed.
            this.characterTableTableAdapter.Fill(this.dnd_DatabaseDataSet1.CharacterTable);
            ResetPage();

            nameTextBox.Text = name;

            int index = 0;

            for(int i = 0; i < dnd_DatabaseDataSet1.CharacterTable.nameColumn.Table.Rows.Count - 1; i++)
            {
                if(name == dnd_DatabaseDataSet1.CharacterTable.Rows[i]["name"].ToString())
                {
                    index = i;
                    break;
                }
            }

            //levelTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.levelColumn.Table.Rows[index].ToString();
            levelTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["level"].ToString();
            genderTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["gender"].ToString();
            raceTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["race"].ToString();
            roleTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["role"].ToString();
            strengthTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["strength"].ToString();
            dexterityTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["dexterity"].ToString();
            constitutionTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["constitution"].ToString();
            intelligenceTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["intelligence"].ToString();
            wisdomTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["wisdom"].ToString();
            charismaTextBox.Text = dnd_DatabaseDataSet1.CharacterTable.Rows[index]["charisma"].ToString();
        }

        private void ResetPage()
        {
            nameTextBox.Text = string.Empty;
            levelTextBox.Text = string.Empty;
            genderTextBox.Text = string.Empty;
            raceTextBox.Text = string.Empty;
            roleTextBox.Text = string.Empty;
            strengthTextBox.Text = string.Empty;
            dexterityTextBox.Text = string.Empty;
            constitutionTextBox.Text = string.Empty;
            intelligenceTextBox.Text = string.Empty;
            wisdomTextBox.Text = string.Empty;
            charismaTextBox.Text = string.Empty;
        }


    }
}
