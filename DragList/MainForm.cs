/*
 *  * User: RDressing@gmail.com
 * Date: 2/20/2011
 * Time: 5:22 PM
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DragGrabber
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
          
            InitializeComponent();
            
           
        }
        
        void LbFilesDragDrop(object sender, DragEventArgs e)
        {
             string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);


        

            foreach (string f in files)
            {
                lbFiles.Items.Add(f);
            }
        }
        
        void LbFilesDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
            e.Effect = DragDropEffects.Copy;
            }
            else
            {
            e.Effect = DragDropEffects.None;
            }
        }
        
        void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        
        void ExitToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            this.Close();
        }
        
        void SelectAllToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            
            for(int i=0; i<lbFiles.Items.Count; i++)
            {
            lbFiles.SetSelected(i,true);
            
            }
        }
        void CopyToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            string toClip = "";
            string sep="";
            foreach( string s in lbFiles.SelectedItems )
            {
                toClip = toClip + sep + s.ToString();
                sep = "\n";
                
            }
            Clipboard.SetDataObject(toClip, true );
        }
        
        void AboutToolStripMenuItemClick(object sender, System.EventArgs e)
        {
            Utility.frmAbout.ShowMe();
        }
    }
}
