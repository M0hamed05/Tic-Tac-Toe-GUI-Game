namespace WindowsFormsApp2
{
    partial class TicTacToe
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.turn = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.Label();
            this.Case = new System.Windows.Forms.Label();
            this.restart_btn = new System.Windows.Forms.Button();
            this.winner_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.question_mark_96;
            this.pictureBox1.Location = new System.Drawing.Point(458, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.question_mark_96;
            this.pictureBox2.Location = new System.Drawing.Point(641, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp2.Properties.Resources.question_mark_96;
            this.pictureBox4.Location = new System.Drawing.Point(458, 208);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(130, 130);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.question_mark_96;
            this.pictureBox3.Location = new System.Drawing.Point(835, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(130, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp2.Properties.Resources.question_mark_96;
            this.pictureBox5.Location = new System.Drawing.Point(641, 208);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 130);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WindowsFormsApp2.Properties.Resources.question_mark_96;
            this.pictureBox6.Location = new System.Drawing.Point(835, 208);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(130, 130);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::WindowsFormsApp2.Properties.Resources.question_mark_96;
            this.pictureBox7.Location = new System.Drawing.Point(458, 380);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(130, 130);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::WindowsFormsApp2.Properties.Resources.question_mark_96;
            this.pictureBox8.Location = new System.Drawing.Point(641, 380);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(130, 130);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.button_click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApp2.Properties.Resources.question_mark_96;
            this.pictureBox9.Location = new System.Drawing.Point(835, 380);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(130, 130);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.button_click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MS Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Snow;
            this.title.Location = new System.Drawing.Point(43, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(343, 56);
            this.title.TabIndex = 9;
            this.title.Text = "Tic Tac Toe";
            // 
            // turn
            // 
            this.turn.AutoSize = true;
            this.turn.Font = new System.Drawing.Font("MS Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turn.ForeColor = System.Drawing.Color.Gold;
            this.turn.Location = new System.Drawing.Point(43, 121);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(140, 56);
            this.turn.TabIndex = 10;
            this.turn.Text = "Turn";
            // 
            // player
            // 
            this.player.AutoSize = true;
            this.player.Font = new System.Drawing.Font("MS Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.player.Location = new System.Drawing.Point(179, 121);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(227, 56);
            this.player.TabIndex = 11;
            this.player.Text = "Player1";
            // 
            // Case
            // 
            this.Case.AutoSize = true;
            this.Case.Font = new System.Drawing.Font("MS Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Case.ForeColor = System.Drawing.Color.Chartreuse;
            this.Case.Location = new System.Drawing.Point(43, 322);
            this.Case.Name = "Case";
            this.Case.Size = new System.Drawing.Size(343, 56);
            this.Case.TabIndex = 12;
            this.Case.Text = "In Progress";
            // 
            // restart_btn
            // 
            this.restart_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.restart_btn.Location = new System.Drawing.Point(103, 410);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.restart_btn.Size = new System.Drawing.Size(232, 100);
            this.restart_btn.TabIndex = 13;
            this.restart_btn.Text = "Restart Game";
            this.restart_btn.UseVisualStyleBackColor = false;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // winner_label
            // 
            this.winner_label.AutoSize = true;
            this.winner_label.Font = new System.Drawing.Font("MS Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner_label.ForeColor = System.Drawing.Color.Gold;
            this.winner_label.Location = new System.Drawing.Point(43, 266);
            this.winner_label.Name = "winner_label";
            this.winner_label.Size = new System.Drawing.Size(198, 56);
            this.winner_label.TabIndex = 14;
            this.winner_label.Text = "Winner";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1012, 547);
            this.Controls.Add(this.winner_label);
            this.Controls.Add(this.restart_btn);
            this.Controls.Add(this.Case);
            this.Controls.Add(this.player);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label turn;
        private System.Windows.Forms.Label player;
        private System.Windows.Forms.Label Case;
        private System.Windows.Forms.Button restart_btn;
        private System.Windows.Forms.Label winner_label;
    }
}

