using GameSource;
using System.Security.AccessControl;
using System.Windows.Forms;
namespace TicTacToeGame
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            ToolTip tip = new ToolTip();
            tip.SetToolTip(one_player, "Play With Pc");
            tip.SetToolTip(two_player, "Play With friend");
            tip.SetToolTip(round_label, "Unlimited");
            tip.SetToolTip(result_button, "result of matches");
        }

        private void one_player_Click(object sender, EventArgs e)
        {
            if (int.TryParse(round_box.Text.ToString(), out int rounds))
            {
                Game.max_round = rounds;
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(round_box, "Enter a valid number");
                return;
            }

            Game.two_players = false;

            for (int i = 1; i <= rounds; i++)
            {
                Game.round = i;
                if (i % 2 == 0) Game.player1turn = false;
                else Game.player1turn = true;

                Play form = new Play();
                form.ShowDialog();
            }

        }

        private void two_player_Click(object sender, EventArgs e)
        {
            if (int.TryParse(round_box.Text.ToString(), out int rounds))
            {
                Game.max_round = rounds;
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(round_box, "Enter a valid number");
                return;
            }

            Game.two_players = true;

            for (int i = 1; i <= rounds; i++)
            {
                Game.round = i;
                Play form = new Play();
                form.ShowDialog();
            }
        }

        private void rounds_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void title_label(object sender, EventArgs e)
        {

        }

        private void rounds_label(object sender, EventArgs e)
        {

        }

        private void result_button_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show($"Player 1 win {Game.player1_win_times} times\n" +
                $"Player 2 win {Game.player2_win_times} times\n" +
                $"Draw {Game.draw_times} times\n" +
                $"Pc win {Game.pc_win_times} times\n", "Result", MessageBoxButtons.OK);
        }
    }
}