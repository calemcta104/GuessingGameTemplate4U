﻿using System;
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
    public partial class ResultsScreen : UserControl
    {
        public ResultsScreen()
        {
            InitializeComponent();
        }

        private void ResultsScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.guesses.Count(); i++)

            {
                orderLabel.Text += Form1.guesses[i] + ", ";
            }

            Form1.guesses.Sort();
            for (int i = 0; i < Form1.guesses.Count(); i++)

            {
                sortedLabel.Text += Form1.guesses[i] + ", ";
            }

            numberOutput.Text = Form1.guesses.Count() + "";

        }
    }
}
