/*
 *  * User: RDressing@gmail.com
 * Date: 2/20/2011
 * Time: 10:52 AM
 * 
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Utility
{
    /// <summary>
    /// Description of frmAbout.
    /// </summary>
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
           lblAppName.Text = Application.ProductName;
           lblCompanyName.Text = Application.CompanyName; 
           lblVersion.Text = Application.ProductVersion;           
               
        }
        
        public static void ShowMe()
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
            f = null;
            
        }
        void FrmAboutLoad(object sender, EventArgs e)
        {
        	
        }
        
        void BtnDismissClick(object sender, EventArgs e)
        {
        	this.Visible =false;
        }
    }
}
