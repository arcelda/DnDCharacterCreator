
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.characterSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(446, 492);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(60, 38);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Return to Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.characterSheetToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // characterSheetToolStripMenuItem
            // 
            this.characterSheetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem,
            this.editInfoToolStripMenuItem});
            this.characterSheetToolStripMenuItem.Name = "characterSheetToolStripMenuItem";
            this.characterSheetToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.characterSheetToolStripMenuItem.Text = "Character Sheet";
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.viewInfoToolStripMenuItem.Text = "View Info";
            // 
            // editInfoToolStripMenuItem
            // 
            this.editInfoToolStripMenuItem.Name = "editInfoToolStripMenuItem";
            this.editInfoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
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
            // 
            // searchSessionsToolStripMenuItem
            // 
            this.searchSessionsToolStripMenuItem.Name = "searchSessionsToolStripMenuItem";
            this.searchSessionsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.searchSessionsToolStripMenuItem.Text = "Search Sessions";
            // 
            // pictureBox1
            // 
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
            this.ClientSize = new System.Drawing.Size(979, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReturningPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Welcome Back";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem characterSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchSessionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}