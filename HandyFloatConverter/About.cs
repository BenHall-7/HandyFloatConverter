using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandyFloatConverter
{
    public partial class About : Form
    {
        public About()
        {
            Icon = Properties.Resources.FoxLogo;
            text_AboutDescription.Text = Properties.Resources.About_Description;

            InitializeComponent();
        }
    }
}
