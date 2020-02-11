using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameTemplate4U
{
    public partial class FinishScreen : UserControl
    {
        public FinishScreen()
        {
            InitializeComponent();

            guessesLabel.Text = "Guesses Made : " + Form1.guessNumbers.Count();
            orginalLabel.Text += "\n";

            for (int i = 0; i < Form1.guessNumbers.Count(); i++)
            {
                orginalLabel.Text += Form1.guessNumbers[i] + ", ";
            }

            Form1.guessNumbers.Sort();

            sortedLabel.Text += "\n";

            for (int i = 0; i < Form1.guessNumbers.Count(); i++)
            {
                sortedLabel.Text += Form1.guessNumbers[i] + ", ";
            }


        }
    }
}
