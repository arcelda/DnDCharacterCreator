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
    public partial class SearchSession : Form
    {
        public SearchSession()
        {
            InitializeComponent();
        }

        private void SearchSession_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnd_DatabaseDataSet.SessionTable' table. You can move, or remove it, as needed.
            this.sessionTableTableAdapter.Fill(this.dnd_DatabaseDataSet.SessionTable);

        }


        

        private void fillBySessionToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sessionTableTableAdapter.FillBySession(this.dnd_DatabaseDataSet.SessionTable, searchNameToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
