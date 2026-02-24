namespace TicTacToeGame
{
    partial class Play
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
            components = new System.ComponentModel.Container();
            position1 = new Button();
            position2 = new Button();
            position3 = new Button();
            position4 = new Button();
            position7 = new Button();
            position5 = new Button();
            position6 = new Button();
            position8 = new Button();
            position9 = new Button();
            Player1_label = new Label();
            Player2_label = new Label();
            current_round = new Label();
            result_label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // position1
            // 
            position1.Font = new Font("Segoe UI Black", 50F);
            position1.Location = new Point(12, 103);
            position1.Name = "position1";
            position1.Size = new Size(140, 140);
            position1.TabIndex = 0;
            position1.TextAlign = ContentAlignment.TopCenter;
            position1.UseVisualStyleBackColor = true;
            position1.Click += position1_Click;
            // 
            // position2
            // 
            position2.Font = new Font("Segoe UI Black", 50F);
            position2.Location = new Point(158, 103);
            position2.Name = "position2";
            position2.Size = new Size(140, 140);
            position2.TabIndex = 1;
            position2.TextAlign = ContentAlignment.TopCenter;
            position2.UseVisualStyleBackColor = true;
            position2.Click += position2_Click;
            // 
            // position3
            // 
            position3.Font = new Font("Segoe UI Black", 50F);
            position3.Location = new Point(304, 103);
            position3.Name = "position3";
            position3.Size = new Size(140, 140);
            position3.TabIndex = 2;
            position3.TextAlign = ContentAlignment.TopCenter;
            position3.UseVisualStyleBackColor = true;
            position3.Click += position3_Click;
            // 
            // position4
            // 
            position4.Font = new Font("Segoe UI Black", 50F);
            position4.Location = new Point(12, 249);
            position4.Name = "position4";
            position4.Size = new Size(140, 140);
            position4.TabIndex = 3;
            position4.TextAlign = ContentAlignment.TopCenter;
            position4.UseVisualStyleBackColor = true;
            position4.Click += position4_Click;
            // 
            // position7
            // 
            position7.Font = new Font("Segoe UI Black", 50F);
            position7.Location = new Point(12, 395);
            position7.Name = "position7";
            position7.Size = new Size(140, 140);
            position7.TabIndex = 4;
            position7.TextAlign = ContentAlignment.TopCenter;
            position7.UseVisualStyleBackColor = true;
            position7.Click += position7_Click;
            // 
            // position5
            // 
            position5.Font = new Font("Segoe UI Black", 50F);
            position5.Location = new Point(158, 249);
            position5.Name = "position5";
            position5.Size = new Size(140, 140);
            position5.TabIndex = 5;
            position5.TextAlign = ContentAlignment.TopCenter;
            position5.UseVisualStyleBackColor = true;
            position5.Click += position5_Click;
            // 
            // position6
            // 
            position6.Font = new Font("Segoe UI Black", 50F);
            position6.Location = new Point(304, 249);
            position6.Name = "position6";
            position6.Size = new Size(140, 140);
            position6.TabIndex = 6;
            position6.TextAlign = ContentAlignment.TopCenter;
            position6.UseVisualStyleBackColor = true;
            position6.Click += position6_Click;
            // 
            // position8
            // 
            position8.Font = new Font("Segoe UI Black", 50F);
            position8.Location = new Point(158, 395);
            position8.Name = "position8";
            position8.Size = new Size(140, 140);
            position8.TabIndex = 7;
            position8.TextAlign = ContentAlignment.TopCenter;
            position8.UseVisualStyleBackColor = true;
            position8.Click += position8_Click;
            // 
            // position9
            // 
            position9.Font = new Font("Segoe UI Black", 50F);
            position9.Location = new Point(304, 395);
            position9.Name = "position9";
            position9.Size = new Size(140, 140);
            position9.TabIndex = 8;
            position9.TextAlign = ContentAlignment.TopCenter;
            position9.UseVisualStyleBackColor = true;
            position9.Click += position9_Click;
            // 
            // Player1_label
            // 
            Player1_label.AutoSize = true;
            Player1_label.Font = new Font("Segoe UI", 15F);
            Player1_label.Location = new Point(12, 50);
            Player1_label.Name = "Player1_label";
            Player1_label.Size = new Size(52, 41);
            Player1_label.TabIndex = 9;
            Player1_label.Tag = "";
            Player1_label.Text = "p1";
            Player1_label.Click += Player1_label_Click;
            // 
            // Player2_label
            // 
            Player2_label.AutoSize = true;
            Player2_label.Font = new Font("Segoe UI", 15F);
            Player2_label.Location = new Point(304, 50);
            Player2_label.Name = "Player2_label";
            Player2_label.Size = new Size(84, 41);
            Player2_label.TabIndex = 10;
            Player2_label.Text = "p2    ";
            Player2_label.Click += Player2_label_Click;
            // 
            // current_round
            // 
            current_round.AutoSize = true;
            current_round.Font = new Font("Segoe UI", 15F);
            current_round.Location = new Point(12, 9);
            current_round.Name = "current_round";
            current_round.Size = new Size(113, 41);
            current_round.TabIndex = 11;
            current_round.Text = "Round ";
            current_round.Click += current_round_click;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.Font = new Font("Segoe UI", 15F);
            result_label.Location = new Point(255, 9);
            result_label.Name = "result_label";
            result_label.Size = new Size(114, 41);
            result_label.TabIndex = 12;
            result_label.Text = "            ";
            result_label.Click += result_label_Click;
            // 
            // play
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 546);
            Controls.Add(result_label);
            Controls.Add(current_round);
            Controls.Add(Player2_label);
            Controls.Add(Player1_label);
            Controls.Add(position9);
            Controls.Add(position8);
            Controls.Add(position6);
            Controls.Add(position5);
            Controls.Add(position7);
            Controls.Add(position4);
            Controls.Add(position3);
            Controls.Add(position2);
            Controls.Add(position1);
            Name = "play";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button position1;
        private Button position2;
        private Button position3;
        private Button position4;
        private Button position7;
        private Button position5;
        private Button position6;
        private Button position8;
        private Button position9;
        private Label Player1_label;
        private Label Player2_label;
        private Label current_round;
        private Label result_label;
        private System.Windows.Forms.Timer timer1;
    }
}