
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
            this.p_test = new System.Windows.Forms.Panel();
            this.l_test = new System.Windows.Forms.Label();
            this.picb_test = new System.Windows.Forms.PictureBox();
            this.p_close = new System.Windows.Forms.Panel();
            this.l_close = new System.Windows.Forms.Label();
            this.pixb_close = new System.Windows.Forms.PictureBox();
            this.p_import = new System.Windows.Forms.Panel();
            this.l_import = new System.Windows.Forms.Label();
            this.picb_import = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_import = new System.Windows.Forms.Panel();
            this.rtb_answer = new System.Windows.Forms.RichTextBox();
            this.rtb_question = new System.Windows.Forms.RichTextBox();
            this.picb_answer = new System.Windows.Forms.PictureBox();
            this.picb_question = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.p_test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_test)).BeginInit();
            this.p_close.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixb_close)).BeginInit();
            this.p_import.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_import)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_import.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_question)).BeginInit();
            this.panel2.SuspendLayout();
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
            // rtb_answer
            // 
            this.rtb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_answer.Location = new System.Drawing.Point(123, 429);
            this.rtb_answer.Name = "rtb_answer";
            this.rtb_answer.Size = new System.Drawing.Size(743, 261);
            this.rtb_answer.TabIndex = 4;
            this.rtb_answer.Text = "";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(232, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 712);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = ".....";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(55, 118);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 33);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = ".....";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(476, 118);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 33);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = ".....";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(51, 210);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 33);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = ".....";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(476, 210);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 33);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = ".....";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 364);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(817, 264);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(51, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "True: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(212, 663);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "False: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(122, 663);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(291, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 736);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_import);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.p_test.ResumeLayout(false);
            this.p_test.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_test)).EndInit();
            this.p_close.ResumeLayout(false);
            this.p_close.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixb_close)).EndInit();
            this.p_import.ResumeLayout(false);
            this.p_import.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_import)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_import.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_question)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
    }
}

