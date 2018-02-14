using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HandyFloatConverter
{
    public partial class MainForm : Form
    {
        public string floatString = "";
        public string hexString = "";
        public bool useDouble = false;
        public bool useLittleEndian = false;

        public MainForm()
        {
            Icon = Properties.Resources.FoxLogo;

            InitializeComponent();
        }

        #region UpdateSubMethods

        private void UpdateFloatFromHexSub()
        {
            hexString = tB_Hex.Text;
            int typeLength;
            if (useDouble)
                typeLength = 16;
            else
                typeLength = 8;

            if (hexString.Length > typeLength)
            {
                int newSelectionStart = tB_Hex.SelectionStart;//record the value of selection start before changing text
                int charIndexToRemove = newSelectionStart;
                if (charIndexToRemove > typeLength)
                    charIndexToRemove--;
                hexString = hexString.Remove(charIndexToRemove, 1);
                tB_Hex.Text = hexString;
                tB_Hex.SelectionStart = newSelectionStart;
                return;
            }

            bool succeedParse = true;

            char[] hexCharArray = hexString.ToCharArray();//convert the string to char array
            string[] hex2CharArray = new string[hexCharArray.Length / 2];//every byte is 2 chars long, so list of every pair
            byte[] hexByteArray = new byte[hex2CharArray.Length];

            for (int i = 0; i < hex2CharArray.Length; i++)
            {
                string concat = hexCharArray[2 * i].ToString() + hexCharArray[2 * i + 1].ToString();
                hex2CharArray[i] = concat;
            }
            for (int i = 0; i < hexByteArray.Length; i++)
            {
                succeedParse &= byte.TryParse(hex2CharArray[i], System.Globalization.NumberStyles.HexNumber, null, out hexByteArray[i]);
                //all bytes must parse successfully
            }

            if (hexCharArray.Length != typeLength)
                floatString = "";//assumes you haven't finished writing
            else if (!succeedParse)
                floatString = Properties.Resources.Parse_Error;
            else
            {
                Array.Reverse(hexByteArray);
                if (!useDouble)
                    floatString = BitConverter.ToSingle(hexByteArray, 0).ToString();
                else
                    floatString = BitConverter.ToDouble(hexByteArray, 0).ToString();
            }
            tB_Float.Text = floatString;
        }

        private void UpdateHexFromFloatSub()
        {
            floatString = tB_Float.Text;
            float floatValue = 0;
            double doubleValue = 0;
            bool succeedParse = false;

            if (!useDouble)
                succeedParse = float.TryParse(floatString, out floatValue);
            else
                succeedParse = double.TryParse(floatString, out doubleValue);

            if (floatString == "")
                hexString = "";
            else if (succeedParse)
            {
                byte[] floatByteArray;
                if (!useDouble)
                    floatByteArray = BitConverter.GetBytes(floatValue);
                else
                    floatByteArray = BitConverter.GetBytes(doubleValue);

                Array.Reverse(floatByteArray);
                hexString = "";//resetting string so that we can add the bytes incrementally
                foreach (byte value in floatByteArray)
                {
                    hexString += value.ToString("X2");
                }
            }
            else
                hexString = Properties.Resources.Parse_Error;

            tB_Hex.Text = hexString;
        }

        #endregion

        private void RemoveErrorTextOnFocus()
        {
            if (tB_Float.Focused)
            {
                if (tB_Float.Text == Properties.Resources.Parse_Error)
                    tB_Float.Text = "";
            }
            else if (tB_Hex.Focused)
            {
                if (tB_Hex.Text == Properties.Resources.Parse_Error)
                    tB_Hex.Text = "";
            }
        }

        private void UpdateHexFromFloat(object sender, EventArgs e)
        {
            if (tB_Float.Focused)
            {
                UpdateHexFromFloatSub();
            }
        }

        private void UpdateFloatFromHex(object sender, EventArgs e)
        {
            if (tB_Hex.Focused)
            {
                UpdateFloatFromHexSub();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutDialog = new About();
            aboutDialog.ShowDialog();
        }

        private void repositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo repoLink = new ProcessStartInfo("https://github.com/BenHall-7/HandyFloatConverter");
            Process.Start(repoLink);
        }

        private void cB_Double_CheckedChanged(object sender, EventArgs e)
        {
            useDouble = cB_Double.Checked;
            UpdateHexFromFloatSub();//skips the check for focus in the Float text box
        }

        private void tB_Float_Enter(object sender, EventArgs e)
        {
            RemoveErrorTextOnFocus();
        }

        private void tB_Hex_Enter(object sender, EventArgs e)
        {
            RemoveErrorTextOnFocus();
        }
    }
}
