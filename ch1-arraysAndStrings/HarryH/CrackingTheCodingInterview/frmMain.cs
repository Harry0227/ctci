﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackingTheCodingInterview
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStringCompression_Click(object sender, EventArgs e)
        {
            string inputString;
            string outputString;

            inputString = txtInput.Text;
            outputString=CompressString(inputString);

            txtOut.Text = outputString;

        }

        private static string CompressString(string str)
        {
            string compressedString = "";
            int countConsecutive = 0;
            for (int i=0; i< str.Length; i++)
            {
                countConsecutive++;

                if (i+1>= str.Length || str[i]!=str[i+1])
                {
                    compressedString += "" + str[i] + countConsecutive;
                    countConsecutive = 0;

                }
            }

            if (compressedString.Length < str.Length)
            {
                return compressedString;
            }
            else 
            {

                return str;
            }

        }

    }

    
    
}
