using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;


namespace Notepad
{
    public partial class fm_notepad : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        public fm_notepad()
        {
            InitializeComponent();
        }
        
        private void NewFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.rtb_pad.Text))
                {
                    MessageBox.Show("You need to save first ! ");
                }
                else
                {
                    this.rtb_pad.Text = string.Empty;
                    this.Text = "Untitled";
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        private void SaveFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(this.rtb_pad.Text))
                {
                    saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Text File|*.txt";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, this.rtb_pad.Text);
                    }
                }
                else
                {
                    MessageBox.Show("There's nothing to save !");
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        private void OpenFile()
        {
            try
            {
                openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Text File|*.txt";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.rtb_pad.Text = File.ReadAllText(openFileDialog1.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while trying to open file !");
            }
            finally
            {
                openFileDialog1 = null;
            }
        }
        private void NewWindow()
        {
            try
            {
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewWindow();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(this.rtb_pad.Text))
                {
                    MessageBox.Show("You have to save before closing the program !");
                    SaveFile();
                }
            }
            catch (Exception ex)
            {
                this.Close();
            }
            finally
            {

            }
        }
    }
}
