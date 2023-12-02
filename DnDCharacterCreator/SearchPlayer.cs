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
    public partial class SearchPlayer : Form
    {
        public SearchPlayer()
        {
            InitializeComponent();
        }

        private void characterTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.characterTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dnd_DatabaseDataSet1);

        }

        private void SearchPlayer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnd_DatabaseDataSet1.CharacterTable' table. You can move, or remove it, as needed.
            this.characterTableTableAdapter.Fill(this.dnd_DatabaseDataSet1.CharacterTable);

        }
    }
}
