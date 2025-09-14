namespace GameSource
{

    internal class Game
    {
            protected static char[] positions = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            protected static readonly Random rnd = new Random();//static so won't repeat numbers

            protected static int _player1_win_times = 0;
            protected static int _player2_win_times = 0;
            protected static int _pc_win_times = 0;
            protected static int _draw_times = 0;
            protected static int _round = 1;
            protected static int _max_round = 0;
            protected static bool _2players = false;
            protected static bool _player1turn = true;

            public static int player1_win_times { get => _player1_win_times; set => _player1_win_times = value; }
            public static int player2_win_times { get => _player2_win_times; set => _player2_win_times = value; }
            public static int pc_win_times { get => _pc_win_times; set => _pc_win_times = value; }
            public static int draw_times { get => _draw_times; set => _draw_times = value; }
            public static int round { get => _round; set => _round = value; }
            public static int max_round { get => _max_round; set => _max_round = value; }
            public static bool two_players { get => _2players; set => _2players = value; }
            public static bool player1turn { get => _player1turn; set => _player1turn = value; }

    }
}


