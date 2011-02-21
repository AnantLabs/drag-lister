/*
 *  * User: RDressing@gmail.com
 * Date: 2/20/2011
 * Time: 10:52 AM
 * 
 * 
 */
namespace Utility
{
    partial class frmAbout
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
        	this.lblAppName = new System.Windows.Forms.Label();
        	this.btnDismiss = new System.Windows.Forms.Button();
        	this.lblCompanyName = new System.Windows.Forms.Label();
        	this.lblVersion = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// lblAppName
        	// 
        	this.lblAppName.Location = new System.Drawing.Point(3, 21);
        	this.lblAppName.Name = "lblAppName";
        	this.lblAppName.Size = new System.Drawing.Size(277, 23);
        	this.lblAppName.TabIndex = 0;
        	this.lblAppName.Text = "_____";
        	this.lblAppName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// btnDismiss
        	// 
        	this.btnDismiss.Location = new System.Drawing.Point(105, 102);
        	this.btnDismiss.Name = "btnDismiss";
        	this.btnDismiss.Size = new System.Drawing.Size(75, 23);
        	this.btnDismiss.TabIndex = 1;
        	this.btnDismiss.Text = "OK";
        	this.btnDismiss.UseVisualStyleBackColor = true;
        	this.btnDismiss.Click += new System.EventHandler(this.BtnDismissClick);
        	// 
        	// lblAppDesc
        	// 
        	this.lblCompanyName.Location = new System.Drawing.Point(3, 45);
        	this.lblCompanyName.Name = "lblAppDesc";
        	this.lblCompanyName.Size = new System.Drawing.Size(277, 23);
        	this.lblCompanyName.TabIndex = 2;
        	this.lblCompanyName.Text = "____";
        	this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// lblVersion
        	// 
        	this.lblVersion.Location = new System.Drawing.Point(3, 68);
        	this.lblVersion.Name = "lblVersion";
        	this.lblVersion.Size = new System.Drawing.Size(277, 23);
        	this.lblVersion.TabIndex = 3;
        	this.lblVersion.Text = "____";
        	this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// frmAbout
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(285, 137);
        	this.Controls.Add(this.lblVersion);
        	this.Controls.Add(this.lblCompanyName);
        	this.Controls.Add(this.btnDismiss);
        	this.Controls.Add(this.lblAppName);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.Name = "frmAbout";
        	this.ShowInTaskbar = false;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "frmAbout";
        	this.Load += new System.EventHandler(this.FrmAboutLoad);
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnDismiss;
    }
}
