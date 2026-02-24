using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        Image question_image = Properties.Resources.question_mark_96;
        Image x_image = Properties.Resources.X;
        Image o_image = Properties.Resources.O;
        bool player1_turn = true;

        int times_of_moves = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = question_image;
            pictureBox2.Image = question_image;
            pictureBox3.Image = question_image;
            pictureBox4.Image = question_image;
            pictureBox5.Image = question_image;
            pictureBox6.Image = question_image;
            pictureBox7.Image = question_image;
            pictureBox8.Image = question_image;
            pictureBox9.Image = question_image;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            Pen pen = new Pen(white);
            pen.Width = 8;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 540, 20, 540, 335);
            e.Graphics.DrawLine(pen, 405, 20, 405, 335);
            e.Graphics.DrawLine(pen, 320, 125, 630, 125);
            e.Graphics.DrawLine(pen, 320, 235, 630, 235);
        }

        private void button_click(object sender, EventArgs e)
        {
            box_click((PictureBox)sender);
        }

        private void box_click(PictureBox box)
        {
            if (box.Image == question_image)
            {
                if (player1_turn)
                {
                    box.Image = x_image;
                    player1_turn = false;
                    player.Text = "Player2";
                }
                else
                {
                    box.Image = o_image;
                    player1_turn = true;
                    player.Text = "Player1";
                }
                times_of_moves++;
                Image winner = check_winner();

                if (winner != null)
                {
                    if (winner == x_image) Case.Text = "Player1";
                    else Case.Text = "Player2";
                    disable_buttons();
                }
                if(times_of_moves == 9)
                {
                    Case.Text = "Draw";
                }
            }
        }

        private Image check_winner()
        {
            if (pictureBox1.Image == pictureBox2.Image && pictureBox2.Image == pictureBox3.Image && pictureBox1.Image != question_image)
                return pictureBox1.Image;
            if (pictureBox4.Image == pictureBox5.Image && pictureBox5.Image == pictureBox6.Image && pictureBox4.Image != question_image)
                return pictureBox4.Image;
            if (pictureBox7.Image == pictureBox8.Image && pictureBox8.Image == pictureBox9.Image && pictureBox7.Image != question_image)
                return pictureBox7.Image;
            if (pictureBox1.Image == pictureBox4.Image && pictureBox4.Image == pictureBox7.Image && pictureBox1.Image != question_image)
                return pictureBox1.Image;
            if (pictureBox2.Image == pictureBox5.Image && pictureBox5.Image == pictureBox8.Image && pictureBox2.Image != question_image)
                return pictureBox2.Image;
            if (pictureBox3.Image == pictureBox6.Image && pictureBox6.Image == pictureBox9.Image && pictureBox3.Image != question_image)
                return pictureBox3.Image;
            if (pictureBox1.Image == pictureBox5.Image && pictureBox5.Image == pictureBox9.Image && pictureBox1.Image != question_image)
                return pictureBox1.Image;
            if (pictureBox3.Image == pictureBox5.Image && pictureBox5.Image == pictureBox7.Image && pictureBox3.Image != question_image)
                return pictureBox3.Image;
            return null;
        }

        private void disable_buttons()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
        }

        private void reset_buttons()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;

            pictureBox1.Image = question_image;
            pictureBox2.Image = question_image;
            pictureBox3.Image = question_image;
            pictureBox4.Image = question_image;
            pictureBox5.Image = question_image;
            pictureBox6.Image = question_image;
            pictureBox7.Image = question_image;
            pictureBox8.Image = question_image;
            pictureBox9.Image = question_image;

            Case.Text = "In Progress";

        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            reset_buttons();
        }

    }
}
