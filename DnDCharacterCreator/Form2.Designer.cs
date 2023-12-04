
namespace DnDCharacterCreator
{
    partial class FormReturningPlayer
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.characterSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dnd_DatabaseDataSet1 = new DnDCharacterCreator.Dnd_DatabaseDataSet1();
            this.characterTableTableAdapter = new DnDCharacterCreator.Dnd_DatabaseDataSet1TableAdapters.CharacterTableTableAdapter();
            this.tableAdapterManager = new DnDCharacterCreator.Dnd_DatabaseDataSet1TableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.strengthTextBox = new System.Windows.Forms.TextBox();
            this.dexterityTextBox = new System.Windows.Forms.TextBox();
            this.constitutionTextBox = new System.Windows.Forms.TextBox();
            this.intelligenceTextBox = new System.Windows.Forms.TextBox();
            this.wisdomTextBox = new System.Windows.Forms.TextBox();
            this.charismaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnd_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(443, 492);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(102, 38);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Return to Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterSheetToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // characterSheetToolStripMenuItem
            // 
            this.characterSheetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInfoToolStripMenuItem});
            this.characterSheetToolStripMenuItem.Name = "characterSheetToolStripMenuItem";
            this.characterSheetToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.characterSheetToolStripMenuItem.Text = "Character Sheet";
            // 
            // editInfoToolStripMenuItem
            // 
            this.editInfoToolStripMenuItem.Enabled = false;
            this.editInfoToolStripMenuItem.Name = "editInfoToolStripMenuItem";
            this.editInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editInfoToolStripMenuItem.Text = "Edit Info";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchPlayersToolStripMenuItem,
            this.searchSessionsToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // searchPlayersToolStripMenuItem
            // 
            this.searchPlayersToolStripMenuItem.Name = "searchPlayersToolStripMenuItem";
            this.searchPlayersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.searchPlayersToolStripMenuItem.Text = "Search Players";
            this.searchPlayersToolStripMenuItem.Click += new System.EventHandler(this.searchPlayersToolStripMenuItem_Click);
            // 
            // searchSessionsToolStripMenuItem
            // 
            this.searchSessionsToolStripMenuItem.Name = "searchSessionsToolStripMenuItem";
            this.searchSessionsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.searchSessionsToolStripMenuItem.Text = "Search Sessions";
            this.searchSessionsToolStripMenuItem.Click += new System.EventHandler(this.searchSessionsToolStripMenuItem_Click);
            // 
            // characterTableBindingSource
            // 
            this.characterTableBindingSource.DataMember = "CharacterTable";
            this.characterTableBindingSource.DataSource = this.dnd_DatabaseDataSet1;
            // 
            // dnd_DatabaseDataSet1
            // 
            this.dnd_DatabaseDataSet1.DataSetName = "Dnd_DatabaseDataSet1";
            this.dnd_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // characterTableTableAdapter
            // 
            this.characterTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharacterTableTableAdapter = this.characterTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = DnDCharacterCreator.Dnd_DatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(73, 139);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(218, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // levelTextBox
            // 
            this.levelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "level", true));
            this.levelTextBox.Enabled = false;
            this.levelTextBox.Location = new System.Drawing.Point(488, 79);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(29, 20);
            this.levelTextBox.TabIndex = 10;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "gender", true));
            this.genderTextBox.Enabled = false;
            this.genderTextBox.Location = new System.Drawing.Point(393, 126);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(100, 20);
            this.genderTextBox.TabIndex = 12;
            // 
            // raceTextBox
            // 
            this.raceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "race", true));
            this.raceTextBox.Enabled = false;
            this.raceTextBox.Location = new System.Drawing.Point(566, 79);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.Size = new System.Drawing.Size(68, 20);
            this.raceTextBox.TabIndex = 14;
            // 
            // roleTextBox
            // 
            this.roleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "role", true));
            this.roleTextBox.Enabled = false;
            this.roleTextBox.Location = new System.Drawing.Point(352, 79);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.Size = new System.Drawing.Size(94, 20);
            this.roleTextBox.TabIndex = 16;
            // 
            // strengthTextBox
            // 
            this.strengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "strength", true));
            this.strengthTextBox.Enabled = false;
            this.strengthTextBox.Location = new System.Drawing.Point(143, 228);
            this.strengthTextBox.Name = "strengthTextBox";
            this.strengthTextBox.Size = new System.Drawing.Size(24, 20);
            this.strengthTextBox.TabIndex = 18;
            // 
            // dexterityTextBox
            // 
            this.dexterityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "dexterity", true));
            this.dexterityTextBox.Enabled = false;
            this.dexterityTextBox.Location = new System.Drawing.Point(143, 315);
            this.dexterityTextBox.Name = "dexterityTextBox";
            this.dexterityTextBox.Size = new System.Drawing.Size(24, 20);
            this.dexterityTextBox.TabIndex = 20;
            // 
            // constitutionTextBox
            // 
            this.constitutionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "constitution", true));
            this.constitutionTextBox.Enabled = false;
            this.constitutionTextBox.Location = new System.Drawing.Point(143, 402);
            this.constitutionTextBox.Name = "constitutionTextBox";
            this.constitutionTextBox.Size = new System.Drawing.Size(24, 20);
            this.constitutionTextBox.TabIndex = 22;
            // 
            // intelligenceTextBox
            // 
            this.intelligenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "intelligence", true));
            this.intelligenceTextBox.Enabled = false;
            this.intelligenceTextBox.Location = new System.Drawing.Point(279, 228);
            this.intelligenceTextBox.Name = "intelligenceTextBox";
            this.intelligenceTextBox.Size = new System.Drawing.Size(24, 20);
            this.intelligenceTextBox.TabIndex = 24;
            // 
            // wisdomTextBox
            // 
            this.wisdomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "wisdom", true));
            this.wisdomTextBox.Enabled = false;
            this.wisdomTextBox.Location = new System.Drawing.Point(279, 315);
            this.wisdomTextBox.Name = "wisdomTextBox";
            this.wisdomTextBox.Size = new System.Drawing.Size(24, 20);
            this.wisdomTextBox.TabIndex = 26;
            // 
            // charismaTextBox
            // 
            this.charismaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterTableBindingSource, "charisma", true));
            this.charismaTextBox.Enabled = false;
            this.charismaTextBox.Location = new System.Drawing.Point(279, 402);
            this.charismaTextBox.Name = "charismaTextBox";
            this.charismaTextBox.Size = new System.Drawing.Size(24, 20);
            this.charismaTextBox.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DnDCharacterCreator.Properties.Resources.DnD_simple_sheet;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.characterTableBindingSource, "name", true));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::DnDCharacterCreator.Properties.Resources.DnD_simple_sheet;
            this.pictureBox1.Location = new System.Drawing.Point(32, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormReturningPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnDCharacterCreator.Properties.Resources.ch2fkon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 550);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.raceTextBox);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.strengthTextBox);
            this.Controls.Add(this.dexterityTextBox);
            this.Controls.Add(this.constitutionTextBox);
            this.Controls.Add(this.intelligenceTextBox);
            this.Controls.Add(this.wisdomTextBox);
            this.Controls.Add(this.charismaTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReturningPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Welcome Back";
            this.Load += new System.EventHandler(this.FormReturningPlayer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnd_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem characterSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchSessionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Dnd_DatabaseDataSet1 dnd_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource characterTableBindingSource;
        private Dnd_DatabaseDataSet1TableAdapters.CharacterTableTableAdapter characterTableTableAdapter;
        private Dnd_DatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.TextBox strengthTextBox;
        private System.Windows.Forms.TextBox dexterityTextBox;
        private System.Windows.Forms.TextBox constitutionTextBox;
        private System.Windows.Forms.TextBox intelligenceTextBox;
        private System.Windows.Forms.TextBox wisdomTextBox;
        private System.Windows.Forms.TextBox charismaTextBox;
    }
}