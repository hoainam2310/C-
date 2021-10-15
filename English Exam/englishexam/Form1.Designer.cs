
namespace englishexam
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_import = new System.Windows.Forms.Panel();
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.rtb_answer = new System.Windows.Forms.RichTextBox();
            this.p_import = new System.Windows.Forms.Panel();
            this.l_import = new System.Windows.Forms.Label();
            this.p_test = new System.Windows.Forms.Panel();
            this.l_test = new System.Windows.Forms.Label();
            this.p_close = new System.Windows.Forms.Panel();
            this.l_close = new System.Windows.Forms.Label();
            this.picb_answer = new System.Windows.Forms.PictureBox();
            this.picb_question = new System.Windows.Forms.PictureBox();
            this.pixb_close = new System.Windows.Forms.PictureBox();
            this.picb_test = new System.Windows.Forms.PictureBox();
            this.picb_import = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_import.SuspendLayout();
            this.p_import.SuspendLayout();
            this.p_test.SuspendLayout();
            this.p_close.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_question)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.p_test);
            this.panel1.Controls.Add(this.p_close);
            this.panel1.Controls.Add(this.p_import);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 712);
            this.panel1.TabIndex = 0;
            // 
            // panel_import
            // 
            this.panel_import.BackColor = System.Drawing.Color.White;
            this.panel_import.Controls.Add(this.rtb_answer);
            this.panel_import.Controls.Add(this.rtb_question);
            this.panel_import.Controls.Add(this.picb_answer);
            this.panel_import.Controls.Add(this.picb_question);
            this.panel_import.Location = new System.Drawing.Point(235, 12);
            this.panel_import.Name = "panel_import";
            this.panel_import.Size = new System.Drawing.Size(883, 712);
            this.panel_import.TabIndex = 1;
            // 
            // rtb_question
            // 
            this.rtb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_question.Location = new System.Drawing.Point(123, 14);
            this.rtb_question.Name = "rtb_question";
            this.rtb_question.Size = new System.Drawing.Size(743, 403);
            this.rtb_question.TabIndex = 3;
            this.rtb_question.Text = "";
            // 
            // rtb_answer
            // 
            this.rtb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_answer.Location = new System.Drawing.Point(123, 429);
            this.rtb_answer.Name = "rtb_answer";
            this.rtb_answer.Size = new System.Drawing.Size(743, 261);
            this.rtb_answer.TabIndex = 4;
            this.rtb_answer.Text = "";
            // 
            // p_import
            // 
            this.p_import.BackColor = System.Drawing.Color.CadetBlue;
            this.p_import.Controls.Add(this.l_import);
            this.p_import.Controls.Add(this.picb_import);
            this.p_import.Location = new System.Drawing.Point(0, 237);
            this.p_import.Name = "p_import";
            this.p_import.Size = new System.Drawing.Size(217, 70);
            this.p_import.TabIndex = 5;
            this.p_import.Click += new System.EventHandler(this.p_import_Click);
            // 
            // l_import
            // 
            this.l_import.AutoSize = true;
            this.l_import.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_import.ForeColor = System.Drawing.Color.White;
            this.l_import.Location = new System.Drawing.Point(77, 23);
            this.l_import.Name = "l_import";
            this.l_import.Size = new System.Drawing.Size(78, 27);
            this.l_import.TabIndex = 5;
            this.l_import.Text = "Import";
            this.l_import.Click += new System.EventHandler(this.l_import_Click);
            // 
            // p_test
            // 
            this.p_test.BackColor = System.Drawing.Color.CadetBlue;
            this.p_test.Controls.Add(this.l_test);
            this.p_test.Controls.Add(this.picb_test);
            this.p_test.Location = new System.Drawing.Point(0, 313);
            this.p_test.Name = "p_test";
            this.p_test.Size = new System.Drawing.Size(217, 70);
            this.p_test.TabIndex = 6;
            // 
            // l_test
            // 
            this.l_test.AutoSize = true;
            this.l_test.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_test.ForeColor = System.Drawing.Color.White;
            this.l_test.Location = new System.Drawing.Point(77, 24);
            this.l_test.Name = "l_test";
            this.l_test.Size = new System.Drawing.Size(50, 27);
            this.l_test.TabIndex = 5;
            this.l_test.Text = "Test";
            // 
            // p_close
            // 
            this.p_close.BackColor = System.Drawing.Color.Peru;
            this.p_close.Controls.Add(this.l_close);
            this.p_close.Controls.Add(this.pixb_close);
            this.p_close.Location = new System.Drawing.Point(0, 641);
            this.p_close.Name = "p_close";
            this.p_close.Size = new System.Drawing.Size(217, 71);
            this.p_close.TabIndex = 6;
            this.p_close.Click += new System.EventHandler(this.p_close_Click);
            // 
            // l_close
            // 
            this.l_close.AutoSize = true;
            this.l_close.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_close.ForeColor = System.Drawing.Color.White;
            this.l_close.Location = new System.Drawing.Point(77, 22);
            this.l_close.Name = "l_close";
            this.l_close.Size = new System.Drawing.Size(63, 27);
            this.l_close.TabIndex = 5;
            this.l_close.Text = "Close";
            this.l_close.Click += new System.EventHandler(this.l_close_Click);
            // 
            // picb_answer
            // 
            this.picb_answer.Image = global::englishexam.Properties.Resources.ImportKey;
            this.picb_answer.Location = new System.Drawing.Point(20, 429);
            this.picb_answer.Name = "picb_answer";
            this.picb_answer.Size = new System.Drawing.Size(97, 98);
            this.picb_answer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_answer.TabIndex = 2;
            this.picb_answer.TabStop = false;
            this.picb_answer.Click += new System.EventHandler(this.picb_answer_Click);
            // 
            // picb_question
            // 
            this.picb_question.Image = global::englishexam.Properties.Resources.ImportQuestion;
            this.picb_question.Location = new System.Drawing.Point(20, 14);
            this.picb_question.Name = "picb_question";
            this.picb_question.Size = new System.Drawing.Size(97, 98);
            this.picb_question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_question.TabIndex = 1;
            this.picb_question.TabStop = false;
            this.picb_question.Click += new System.EventHandler(this.picb_question_Click);
            // 
            // pixb_close
            // 
            this.pixb_close.Image = global::englishexam.Properties.Resources.Close;
            this.pixb_close.Location = new System.Drawing.Point(3, 3);
            this.pixb_close.Name = "pixb_close";
            this.pixb_close.Size = new System.Drawing.Size(59, 64);
            this.pixb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pixb_close.TabIndex = 5;
            this.pixb_close.TabStop = false;
            this.pixb_close.Click += new System.EventHandler(this.pixb_close_Click);
            // 
            // picb_test
            // 
            this.picb_test.Image = global::englishexam.Properties.Resources.Test;
            this.picb_test.Location = new System.Drawing.Point(3, 3);
            this.picb_test.Name = "picb_test";
            this.picb_test.Size = new System.Drawing.Size(59, 64);
            this.picb_test.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_test.TabIndex = 5;
            this.picb_test.TabStop = false;
            // 
            // picb_import
            // 
            this.picb_import.Image = global::englishexam.Properties.Resources.Import;
            this.picb_import.Location = new System.Drawing.Point(3, 3);
            this.picb_import.Name = "picb_import";
            this.picb_import.Size = new System.Drawing.Size(59, 64);
            this.picb_import.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb_import.TabIndex = 5;
            this.picb_import.TabStop = false;
            this.picb_import.Click += new System.EventHandler(this.picb_import_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::englishexam.Properties.Resources.Exam;
            this.pictureBox1.Location = new System.Drawing.Point(61, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 736);
            this.Controls.Add(this.panel_import);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel_import.ResumeLayout(false);
            this.p_import.ResumeLayout(false);
            this.p_import.PerformLayout();
            this.p_test.ResumeLayout(false);
            this.p_test.PerformLayout();
            this.p_close.ResumeLayout(false);
            this.p_close.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_question)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_import;
        private System.Windows.Forms.PictureBox picb_question;
        private System.Windows.Forms.Panel p_import;
        private System.Windows.Forms.Label l_import;
        private System.Windows.Forms.PictureBox picb_import;
        private System.Windows.Forms.RichTextBox rtb_answer;
        private System.Windows.Forms.RichTextBox rtb_question;
        private System.Windows.Forms.PictureBox picb_answer;
        private System.Windows.Forms.Panel p_close;
        private System.Windows.Forms.Label l_close;
        private System.Windows.Forms.PictureBox pixb_close;
        private System.Windows.Forms.Panel p_test;
        private System.Windows.Forms.Label l_test;
        private System.Windows.Forms.PictureBox picb_test;
    }
}

