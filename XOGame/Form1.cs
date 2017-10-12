using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame
{
    public partial class XOForm : Form
    {
        private Turn _turn;
        private char[,] grid = new char [3,3];

        private void OnFlipped(object sender, EventArgs e)
        {
            _turnLabel.Text = string.Format("{0} Go!", _turn.WhoseTurn);
        }

        public XOForm()
        {
            InitializeComponent();
        }

        private void XOForm_Load(object sender, EventArgs e)
        {
            _turn = new Turn();
            _turn.Flipped += OnFlipped;
            OnFlipped(null, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _01Button.Text = string.Format("{0}", _turn.WhoseTurn);
            grid[0, 1] = _turn.WhoseTurn;
            _turn.Flip();
            _01Button.Enabled = false;
            check();
        }

        private void _00Button_Click(object sender, EventArgs e)
        {
            _00Button.Text = string.Format("{0}", _turn.WhoseTurn);
            grid[0,0] = _turn.WhoseTurn;
            _turn.Flip();
            _00Button.Enabled = false;
            check();

        }

        private void _02Button_Click(object sender, EventArgs e)
        {
            _02Button.Text = string.Format("{0}", _turn.WhoseTurn);
            grid[0, 2] = _turn.WhoseTurn;
            _turn.Flip();
            _02Button.Enabled = false;
            check();
        }

        private void _10Button_Click(object sender, EventArgs e)
        {
            _10Button.Text = string.Format("{0}", _turn.WhoseTurn);
            grid[1, 0] = _turn.WhoseTurn;
            _turn.Flip();
            _10Button.Enabled = false;
            check();
        }

        private void _11Button_Click(object sender, EventArgs e)
        {
            _11Button.Text = string.Format("{0}", _turn.WhoseTurn);
            grid[1, 1] = _turn.WhoseTurn;
            _turn.Flip();
            _11Button.Enabled = false;
            check();
        }

        private void _12Button_Click(object sender, EventArgs e)
        {
            _12Button.Text = string.Format("{0}", _turn.WhoseTurn);
            grid[1, 2] = _turn.WhoseTurn;
            _turn.Flip();
            _12Button.Enabled = false;
            check();
        }

        private void _20Button_Click(object sender, EventArgs e)
        {
            _20Button.Text = string.Format("{0}", _turn.WhoseTurn);
            grid[2, 0] = _turn.WhoseTurn;
            _turn.Flip();
            _20Button.Enabled = false;
            check();
        }

        private void _21Button_Click(object sender, EventArgs e)
        {
            _21Button.Text = string.Format("{0}", _turn.WhoseTurn);
            grid[2, 1] = _turn.WhoseTurn;
            _turn.Flip();
            _21Button.Enabled = false;
            check();
        }

        private void _22Button_Click(object sender, EventArgs e)
        {
            _22Button.Text = string.Format("{0}", _turn.WhoseTurn);
            grid[2, 2] = _turn.WhoseTurn;
            _turn.Flip();
            _22Button.Enabled = false;
            check();
        }

        void check()
        {
            /*  x
             *      x
             *          x
             */
            if (_00Button.Text == "X" && _11Button.Text == "X" && _22Button.Text == "X")
            {
                MessageBox.Show("Player X won.");
            }
            /*  o
             *      o
             *          o
             */
            if (_00Button.Text == "O" && _11Button.Text == "O" && _22Button.Text == "O")
            {
                MessageBox.Show("Player O won.");
            }
            /*          x
             *      x
             *  x
             */
            if (_02Button.Text == "X" && _11Button.Text == "X" && _20Button.Text == "X")
            {
                MessageBox.Show("Player X won.");
            }
            /*          o
             *      o
             *  o
             */
            if (_02Button.Text == "O" && _11Button.Text == "O" && _20Button.Text == "O")
            {
                MessageBox.Show("Player O won.");
            }
            /*  x   x   x
             * 
             */
            if (_00Button.Text == "X" && _01Button.Text == "X" && _02Button.Text == "X")
            {
                MessageBox.Show("Player X won.");
            }
            /*  o   o   o
             * 
             */
            if (_00Button.Text == "O" && _01Button.Text == "O" && _02Button.Text == "O")
            {
                MessageBox.Show("Player O won.");
            }
            /*  x
             *  x
             *  x
             */
            if (_00Button.Text == "X" && _10Button.Text == "X" && _20Button.Text == "X")
            {
                MessageBox.Show("Player X won.");
            }
            /*  o
             *  o
             *  o
             */
            if (_00Button.Text == "O" && _10Button.Text == "O" && _20Button.Text == "O")
            {
                MessageBox.Show("Player O won.");
            }
            /*          x
             *          x
             *          x
             */
            if (_02Button.Text == "X" && _12Button.Text == "X" && _22Button.Text == "X")
            {
                MessageBox.Show("Player X won.");
            }
            /*          o
             *          o
             *          o
             */
            if (_02Button.Text == "O" && _12Button.Text == "O" && _22Button.Text == "O")
            {
                MessageBox.Show("Player O won.");
            }
            /*      x
             *      x
             *      x
             */
            if (_01Button.Text == "X" && _11Button.Text == "X" && _21Button.Text == "X")
            {
                MessageBox.Show("Player X won.");
            }
            /*      o
             *      o
             *      o
             */
            if (_01Button.Text == "O" && _11Button.Text == "O" && _21Button.Text == "O")
            {
                MessageBox.Show("Player O won.");
            }
            /*
             * 
             *  x   x   x
             */
            if (_20Button.Text == "X" && _21Button.Text == "X" && _22Button.Text == "X")
            {
                MessageBox.Show("Player X won.");
            }
            /*
             * 
             *  o   o   o
             */
            if (_20Button.Text == "O" && _21Button.Text == "O" && _22Button.Text == "O")
            {
                MessageBox.Show("Player 0 won.");
            }
            /*
             *  x   x   x 
             *
             */
            if (_10Button.Text == "X" && _11Button.Text == "X" && _12Button.Text == "X")
            {
                MessageBox.Show("Player X won.");
            }
            /*
             *  o   o   o 
             *
             */
            if (_10Button.Text == "O" && _11Button.Text == "O" && _12Button.Text == "O")
            {
                MessageBox.Show("Player O won.");
            }

            //if none of the above if statements are caught and no buttons are left as empty text, display a tie
            if(_00Button.Text != "" && _01Button.Text != "" && _02Button.Text != "" &&
                _10Button.Text != "" && _11Button.Text != "" && _12Button.Text != "" &&
                _20Button.Text != "" && _21Button.Text != "" && _22Button.Text != "")
            {
                MessageBox.Show("Tie.");
            }
        }


    }

    public class Turn
        {
            private char _whoseTurn = 'X';
            private int _turnsLeft = 9;

            public char WhoseTurn
            {
                get { return _whoseTurn; }
            }

            public int TurnsLeft
            {
                get { return _turnsLeft; }
            }

            public void Flip()
            {
                _whoseTurn = (_whoseTurn == 'X') ? 'O' : 'X';
                _turnsLeft--;
                if (_turnsLeft < 0)
                    throw new ApplicationException("TurnsLeft cannot go lower than 0");
                OnFlipped();
            }

            public event EventHandler Flipped;

            private void OnFlipped()
            {
                EventHandler flipped = Flipped;
                if (flipped != null)
                {
                    flipped(this, EventArgs.Empty);
                }
            }
        }
}
