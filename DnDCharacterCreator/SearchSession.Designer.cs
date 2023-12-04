namespace DnDCharacterCreator
{
    partial class SearchSession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchSession));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sessionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnd_DatabaseDataSet = new DnDCharacterCreator.Dnd_DatabaseDataSet();
            this.fillBySessionToolStrip = new System.Windows.Forms.ToolStrip();
            this.searchNameToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchNameToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillBySessionToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sessionTableTableAdapter = new DnDCharacterCreator.Dnd_DatabaseDataSetTableAdapters.SessionTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnd_DatabaseDataSet)).BeginInit();
            this.fillBySessionToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.characterIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sessionTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(88, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 191);
            this.dataGridView1.TabIndex = 4;
            // 
            // sessionIDDataGridViewTextBoxColumn
            // 
            this.sessionIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sessionIDDataGridViewTextBoxColumn.DataPropertyName = "session_ID";
            this.sessionIDDataGridViewTextBoxColumn.HeaderText = "session_ID";
            this.sessionIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sessionIDDataGridViewTextBoxColumn.Name = "sessionIDDataGridViewTextBoxColumn";
            this.sessionIDDataGridViewTextBoxColumn.Width = 84;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 58;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 58;
            // 
            // characterIDDataGridViewTextBoxColumn
            // 
            this.characterIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.characterIDDataGridViewTextBoxColumn.DataPropertyName = "character_ID";
            this.characterIDDataGridViewTextBoxColumn.HeaderText = "character_ID";
            this.characterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.characterIDDataGridViewTextBoxColumn.Name = "characterIDDataGridViewTextBoxColumn";
            this.characterIDDataGridViewTextBoxColumn.Width = 94;
            // 
            // sessionTableBindingSource
            // 
            this.sessionTableBindingSource.DataMember = "SessionTable";
            this.sessionTableBindingSource.DataSource = this.dnd_DatabaseDataSet;
            // 
            // dnd_DatabaseDataSet
            // 
            this.dnd_DatabaseDataSet.DataSetName = "Dnd_DatabaseDataSet";
            this.dnd_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillBySessionToolStrip
            // 
            this.fillBySessionToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBySessionToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchNameToolStripLabel1,
            this.searchNameToolStripTextBox1,
            this.fillBySessionToolStripButton});
            this.fillBySessionToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBySessionToolStrip.Name = "fillBySessionToolStrip";
            this.fillBySessionToolStrip.Size = new System.Drawing.Size(600, 25);
            this.fillBySessionToolStrip.TabIndex = 6;
            this.fillBySessionToolStrip.Text = "fillBySessionToolStrip";
            // 
            // searchNameToolStripLabel1
            // 
            this.searchNameToolStripLabel1.Name = "searchNameToolStripLabel1";
            this.searchNameToolStripLabel1.Size = new System.Drawing.Size(84, 22);
            this.searchNameToolStripLabel1.Text = "SearchSession:";
            // 
            // searchNameToolStripTextBox1
            // 
            this.searchNameToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchNameToolStripTextBox1.Name = "searchNameToolStripTextBox1";
            this.searchNameToolStripTextBox1.Size = new System.Drawing.Size(76, 25);
            // 
            // fillBySessionToolStripButton
            // 
            this.fillBySessionToolStripButton.BackColor = System.Drawing.Color.Orange;
            this.fillBySessionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBySessionToolStripButton.Name = "fillBySessionToolStripButton";
            this.fillBySessionToolStripButton.Size = new System.Drawing.Size(78, 22);
            this.fillBySessionToolStripButton.Text = "FillBySession";
            this.fillBySessionToolStripButton.Click += new System.EventHandler(this.fillBySessionToolStripButton_Click);
            // 
            // sessionTableTableAdapter
            // 
            this.sessionTableTableAdapter.ClearBeforeFill = true;
            // 
            // SearchSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.fillBySessionToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchSession";
            this.Load += new System.EventHandler(this.SearchSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnd_DatabaseDataSet)).EndInit();
            this.fillBySessionToolStrip.ResumeLayout(false);
            this.fillBySessionToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Dnd_DatabaseDataSet dnd_DatabaseDataSet;
        private System.Windows.Forms.BindingSource sessionTableBindingSource;
        private Dnd_DatabaseDataSetTableAdapters.SessionTableTableAdapter sessionTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn characterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBySessionToolStrip;
        private System.Windows.Forms.ToolStripLabel searchNameToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchNameToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillBySessionToolStripButton;
    }
}