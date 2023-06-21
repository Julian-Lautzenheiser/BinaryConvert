using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		private void tboxInput_KeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar;
			if ((cboxMode.SelectedIndex >= 0 && cboxMode.SelectedIndex < 3) || cboxMode.SelectedIndex == 12)
			{ //Only allow 1 and 0 when binary is selected in combo box
				if (ch != 48 && ch != 49)
				{
					e.Handled = true;
					MessageBox.Show("Binary is contained to only 1 and 0");
				}
			}
		}
        private void buttTrans_Click(object sender, EventArgs e)
		{
			int mode = cboxMode.SelectedIndex;
			String input = tboxInput.Text;
			String output = "";

			switch (mode) { 
            case 0: //Binary to Decimal 
					output = binaryToDecimal(input);
				break;
			case 1: //Binary to Octal
					output = binaryToHigher(input, 3);
				break;
			case 2: //Binary to Hexadecimal
					output = binaryToHigher(input, 4);
				break;
			case 3: //Decimal to Binary
				break;
			case 4: //Decimal to Octal
				break;
			case 5: //Decimal to Hexadecimal
				break;
			case 6: //Octal to Binary
				break;
			case 7: //Octal to Decimal
				break;
			case 8: //Octal to Hexadecimal
				break;
			case 9: //Hexadecimal to Binary
				break;
			case 10: //Hexadecimal to Octal
				break;
			case 11: //Hexadecimal to Decimal
				break;
			case 12: //Binary to Alphanumerical
				break;
			case 13: //Octal to Alphanumerical
				break;
			case 14: //Hexadecimal to Alphanumerical
				break;
			case 15: //Alphanumerical to Binary
				break;
			case 16: //Alphanumerical to Octal
				break;
			case 17: //Alphanumerical to Hexadecimal
				break;
			default:
				break;
			}
			tboxOutput.Text = output;
		}

		private String binaryToDecimal(String input)
        {
			int sum = 0;
			int mult = 1;

			for (int i = input.Length - 1; i >= 0; --i)
            {
				sum += mult * ((int)input[i] - 48);
				mult *= 2;
            }

			return sum.ToString();
        }

		private String binaryToHigher(String input, int power)
        {
			String output = "";
			int tempSum = 0;
			int mult = 1;
			int powerCount = 1;
			Dictionary<int, char> hex = new Dictionary<int, char>(); ;
			if (power == 4) //Creates dict for hex logic of #s > 9
			{
				hex.Add(10, 'A');
				hex.Add(11, 'B');
				hex.Add(12, 'C');
				hex.Add(13, 'D');
				hex.Add(14, 'E');
				hex.Add(15, 'F');
			}

			for (int i = input.Length - 1; i >= 0; --i)
			{
				tempSum += mult * ((int)input[i] - 48);
				if (powerCount == power) //Resets multiplyer and sum and adds sum to the output
				{
					if (tempSum > 9) //Inputs a letter for numbers higher than 9
                    {
						output = hex[tempSum] + output;
                    } else
                    {
						output = "" + tempSum + output;
					}
					powerCount = 1;
					mult = 1;
					tempSum = 0;
				}
				else
				{
					mult *= 2;
					powerCount++;
					if (i == 0) //Makes sure full number is outputted if not ending on last
					{
						output = "" + tempSum + output;
					}
				}
			}
			return output;
        }

		private String decimalToBinary(String input)
        {
			int num = int.Parse(input);

			return "";
        }
        
    }
}
