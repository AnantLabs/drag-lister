/*
 *  * User: RDressing@gmail.com
 * Date: 2/20/2011
 * Time: 5:22 PM
 * 
 * 
 */
namespace DragGrabber
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	this.lbFiles = new System.Windows.Forms.ListBox();
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.menuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// lbFiles
        	// 
        	this.lbFiles.AllowDrop = true;
        	this.lbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.lbFiles.FormattingEnabled = true;
        	this.lbFiles.Location = new System.Drawing.Point(0, 24);
        	this.lbFiles.Name = "lbFiles";
        	this.lbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
        	this.lbFiles.Size = new System.Drawing.Size(432, 377);
        	this.lbFiles.TabIndex = 0;
        	this.lbFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.LbFilesDragDrop);
        	this.lbFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.LbFilesDragEnter);
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.editToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(432, 24);
        	this.menuStrip1.TabIndex = 1;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.saveToolStripMenuItem,
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// saveToolStripMenuItem
        	// 
        	this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        	this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.saveToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
        	this.saveToolStripMenuItem.Text = "&Save As...";
        	this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
        	// 
        	// editToolStripMenuItem
        	// 
        	this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.selectAllToolStripMenuItem,
        	        	        	this.copyToolStripMenuItem});
        	this.editToolStripMenuItem.Name = "editToolStripMenuItem";
        	this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.editToolStripMenuItem.Text = "&Edit";
        	// 
        	// selectAllToolStripMenuItem
        	// 
        	this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        	this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
        	this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
        	this.selectAllToolStripMenuItem.Text = "Select &All";
        	this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItemClick);
        	// 
        	// copyToolStripMenuItem
        	// 
        	this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        	this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
        	this.copyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
        	this.copyToolStripMenuItem.Text = "&Copy";
        	this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItemClick);
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
        	this.aboutToolStripMenuItem.Text = "&About";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.Location = new System.Drawing.Point(0, 379);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(432, 22);
        	this.statusStrip1.TabIndex = 2;
        	this.statusStrip1.Text = "statusStrip1";
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(432, 401);
        	this.Controls.Add(this.statusStrip1);
        	this.Controls.Add(this.lbFiles);
        	this.Controls.Add(this.menuStrip1);
        	this.MainMenuStrip = this.menuStrip1;
        	this.Name = "MainForm";
        	this.Text = "DragGrabber - Drag Files Here";
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lbFiles;
        

    }
}
