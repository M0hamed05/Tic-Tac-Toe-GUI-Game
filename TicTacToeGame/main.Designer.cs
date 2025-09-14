namespace TicTacToeGame
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            one_player = new Button();
            two_player = new Button();
            round_label = new Label();
            title = new Label();
            toolTip1 = new ToolTip(components);
            errorProvider1 = new ErrorProvider(components);
            round_box = new ComboBox();
            result_button = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // one_player
            // 
            one_player.Anchor = AnchorStyles.None;
            one_player.Font = new Font("Segoe UI", 15F);
            one_player.Location = new Point(12, 82);
            one_player.Name = "one_player";
            one_player.Size = new Size(450, 125);
            one_player.TabIndex = 0;
            one_player.Text = "One Player";
            one_player.UseVisualStyleBackColor = true;
            one_player.Click += one_player_Click;
            // 
            // two_player
            // 
            two_player.Anchor = AnchorStyles.None;
            two_player.Font = new Font("Segoe UI", 15F);
            two_player.Location = new Point(12, 228);
            two_player.Name = "two_player";
            two_player.Size = new Size(450, 125);
            two_player.TabIndex = 1;
            two_player.Text = "Two Players";
            two_player.UseVisualStyleBackColor = true;
            two_player.Click += two_player_Click;
            // 
            // round_label
            // 
            round_label.AutoSize = true;
            round_label.Font = new Font("Segoe UI", 15F);
            round_label.Location = new Point(12, 380);
            round_label.Name = "round_label";
            round_label.Size = new Size(118, 41);
            round_label.TabIndex = 3;
            round_label.Text = "Rounds";
            round_label.Click += rounds_label;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 25F);
            title.Location = new Point(48, 9);
            title.Name = "title";
            title.Size = new Size(376, 67);
            title.TabIndex = 4;
            title.Text = "TicTacToe Game";
            title.Click += title_label;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // round_box
            // 
            round_box.FormattingEnabled = true;
            round_box.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            round_box.Location = new Point(136, 390);
            round_box.Name = "round_box";
            round_box.Size = new Size(49, 33);
            round_box.TabIndex = 5;
            round_box.Text = "1";
            round_box.SelectedIndexChanged += rounds_box_SelectedIndexChanged;
            // 
            // result_button
            // 
            result_button.Font = new Font("Segoe UI", 15F);
            result_button.Location = new Point(311, 370);
            result_button.Name = "result_button";
            result_button.Size = new Size(151, 51);
            result_button.TabIndex = 6;
            result_button.Text = "Result";
            result_button.UseVisualStyleBackColor = true;
            result_button.Click += result_button_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 444);
            Controls.Add(result_button);
            Controls.Add(round_box);
            Controls.Add(title);
            Controls.Add(round_label);
            Controls.Add(two_player);
            Controls.Add(one_player);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button one_player;
        private Button two_player;
        private Label round_label;
        private Label title;
        private ToolTip toolTip1;
        private ErrorProvider errorProvider1;
        private ComboBox round_box;
        private Button result_button;
    }
}
