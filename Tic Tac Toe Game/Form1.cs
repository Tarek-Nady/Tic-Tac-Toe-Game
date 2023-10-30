namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {

        public enum PLayer
        {
            X, O
        }

        PLayer CurrentPlayer;
        Random random = new Random();
        int PLayerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CpuMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                CurrentPlayer = PLayer.O;
                buttons[index].Text = CurrentPlayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index);
                CheckGame();
                GameTimer.Stop();
            }

        }

        private void PLayerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            CurrentPlayer = PLayer.X;
            button.Text = CurrentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            buttons.Remove(button);
            CheckGame();
            GameTimer.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X"
              )
            {
                GameTimer.Stop();
                MessageBox.Show("PLayer Wins", "MDO Says");
                PLayerWinCount++;
                label1.Text = "Player Wins: " + PLayerWinCount;
                RestartGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                GameTimer.Stop();
                MessageBox.Show("Computer Wins", "MDO Says");
                PLayerWinCount++;
                CPUWinCount++;
                label1.Text = "Player Wins: " + CPUWinCount;
                RestartGame();
            }

        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "?";
                button.BackColor = DefaultBackColor;

            }
        }
    }
}