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

namespace englishexam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void p_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pixb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void l_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void p_import_Click(object sender, EventArgs e)
        {
            panel_import.Visible = true;
        }

        private void picb_import_Click(object sender, EventArgs e)
        {
            panel_import.Visible = true;
        }

        private void l_import_Click(object sender, EventArgs e)
        {
            panel_import.Visible = true;
        }

        private void picb_question_Click(object sender, EventArgs e)
        {
            OpenFileDialog question = new OpenFileDialog();
            question.ShowDialog();
            string readfile = File.ReadAllText(question.FileName);
            rtb_question.Text = readfile;
        }

        private void picb_answer_Click(object sender, EventArgs e)
        {
            OpenFileDialog answer = new OpenFileDialog();
            answer.ShowDialog();
            string readfile = File.ReadAllText(answer.FileName);
            rtb_answer.Text = readfile;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
