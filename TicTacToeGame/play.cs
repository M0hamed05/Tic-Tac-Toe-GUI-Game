using GameSource;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    public partial class Play : Form
    {
        static readonly Random rnd = new Random();
        private List<Button> free_buttons = new List<Button>();
        private Button[] buttons;
        bool gameover = false;
        
        public Play()
        {
            InitializeComponent();
        
            this.Load += play_Load;
            this.MaximizeBox = false;

            this.KeyPreview = true;
            this.KeyDown += Play_KeyDown;

        }

        private void play_Load(object sender, EventArgs e)
        {

            print_header();

            do_hoverover();

            buttons = new Button[] { position1,position2,position3,position4,
            position5,position6,position7,position8,position9};

            free_buttons = new List<Button>(){ position1,position2,position3,position4,
            position5,position6,position7,position8,position9};

            foreach (Button btn in buttons)
            {
                btn.Click += Button_Click;
            }

            if (Game.round % 2 == 0 && Game.round != 1 && !Game.two_players)
            { 

                Button btn = free_buttons[rnd.Next(free_buttons.Count)];
                free_buttons.Remove(btn);
                Button_Click(btn, EventArgs.Empty);

                Game.player1turn = true;

            }
        }

        private void do_hoverover()
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(current_round, "current round");
            tip.SetToolTip(Player1_label, "Player 1 win times");
            tip.SetToolTip(Player2_label, "player 2 or pc win times");
            tip.SetToolTip(position1, "Press 1 on Keyboard");
            tip.SetToolTip(position2, "Press 2 on Keyboard");
            tip.SetToolTip(position3, "Press 3 on Keyboard");
            tip.SetToolTip(position4, "Press 4 on Keyboard");
            tip.SetToolTip(position5, "Press 5 on Keyboard");
            tip.SetToolTip(position6, "Press 6 on Keyboard");
            tip.SetToolTip(position7, "Press 7 on Keyboard");
            tip.SetToolTip(position8, "Press 8 on Keyboard");
            tip.SetToolTip(position9, "Press 9 on Keyboard");
        }

        private void print_header()
        {
            current_round.Text = $"Round {Game.round}";
            Player1_label.Text = $"Player 1: {Game.player1_win_times}";
            if (Game.two_players)
                Player2_label.Text = $"Player 2: {Game.player2_win_times}";
            else
                Player2_label.Text = $"Pc: {Game.pc_win_times}";
        }


        private void Play_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
                Button_Click(position1, EventArgs.Empty);
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
                Button_Click(position2, EventArgs.Empty);
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
                Button_Click(position3, EventArgs.Empty);
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
                Button_Click(position4, EventArgs.Empty);
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
                Button_Click(position5, EventArgs.Empty);
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
                Button_Click(position6, EventArgs.Empty);
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
                Button_Click(position7, EventArgs.Empty); 
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
                Button_Click(position8, EventArgs.Empty);
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
                Button_Click(position9, EventArgs.Empty);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (gameover) return;
            if (btn.Text != "") return;

            get_positions(btn);
            print_result();
        }

       
        private void get_positions(Button btn)
        {
            if (Game.two_players)
            {
                if (Game.player1turn)
                {
                    btn.Text = "X";
                    Game.player1turn = false;
                    free_buttons.Remove(btn);

                }
                else
                {
                    btn.Text = "O";
                    Game.player1turn = true;
                    free_buttons.Remove(btn);

                }
            }
            else
            {
                if (Game.player1turn)
                {
                    btn.Text = "X";
                    free_buttons.Remove(btn);

                    if (free_buttons.Count > 0)
                    {
                        if (check_winner() == "X") return;
                        btn = free_buttons[rnd.Next(free_buttons.Count)];
                        btn.Text = "O";
                        free_buttons.Remove(btn);
                    }
                }
                else
                {
                    btn.Text = "O";
                    free_buttons.Remove(btn);
                }

            }
        }

        private string check_winner()
        {
            if (position1.Text == position2.Text && position2.Text == position3.Text) return position1.Text;
            if (position4.Text == position5.Text && position5.Text == position6.Text) return position4.Text;
            if (position7.Text == position8.Text && position8.Text == position9.Text) return position7.Text;

            if (position1.Text == position4.Text && position4.Text == position7.Text) return position1.Text;
            if (position2.Text == position5.Text && position5.Text == position8.Text) return position2.Text;
            if (position3.Text == position6.Text && position6.Text == position9.Text) return position3.Text;

            if (position1.Text == position5.Text && position5.Text == position9.Text) return position1.Text;
            if (position3.Text == position5.Text && position5.Text == position7.Text) return position3.Text;

            return "";
        }

        private async Task print_result()
        {
            if (check_winner() == "O")
            {
                gameover = true;
                if (Game.two_players)
                {
                    result_label.Text = "Player 2 win";
                    Game.player2_win_times++;
                }
                else
                {
                    result_label.Text = "Pc wins";
                    Game.pc_win_times++;
                }

                await Task.Delay(1500);
                this.Hide();
            }
            else if (check_winner() == "X")
            {
                gameover = true;
                result_label.Text = " Player 1 win";
                Game.player1_win_times++;

                await Task.Delay(1500);
                this.Hide();
            }
            else
            {
                if (free_buttons.Count == 0)
                {
                    result_label.Text = "Draw";
                    Game.draw_times++;

                    await Task.Delay(1500);
                    this.Hide();
                }
            }

        }





        private void current_round_click(object sender, EventArgs e)
        {

        }

        private void Player1_label_Click(object sender, EventArgs e)
        {
        }

        private void Player2_label_Click(object sender, EventArgs e)
        {

        }

        private void position1_Click(object sender, EventArgs e)
        {

        }

        private void position2_Click(object sender, EventArgs e)
        {

        }

        private void position3_Click(object sender, EventArgs e)
        {

        }

        private void position4_Click(object sender, EventArgs e)
        {

        }

        private void position5_Click(object sender, EventArgs e)
        {

        }

        private void position6_Click(object sender, EventArgs e)
        {

        }

        private void position7_Click(object sender, EventArgs e)
        {

        }

        private void position8_Click(object sender, EventArgs e)
        {

        }

        private void position9_Click(object sender, EventArgs e)
        {

        }

        private void result_label_Click(object sender, EventArgs e)
        {

        }

    }
}
