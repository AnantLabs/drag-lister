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
using System.IO;
using System.Text;

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
            // anything to save
            if (lbFiles.Items.Count ==0) return; //don't annoy user ..  
            
            // where to save
            string FileName = "";
            saveFileDialog1.DefaultExt ="txt";
           
            saveFileDialog1.ShowDialog();
            FileName = saveFileDialog1.FileName;
           
            
            if (FileName =="") return;  //user did not select a filename
            
            
            // otherwise do it
            
            StringBuilder sb = new StringBuilder();
            foreach( string s in lbFiles.Items )
            {
                sb.AppendLine(s);             
                
            }
            
            try {
            SaveToFile(FileName,sb);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem Saving To File!","Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }
        void SaveToFile(string FileName, StringBuilder Contents)
        {
            using (StreamWriter op =  new StreamWriter(FileName))
            {
                op.Write(Contents.ToString());
            }
            
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
