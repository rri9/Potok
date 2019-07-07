using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Potok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //
            string journals_path = "d:\\Ruslan\\Potok\\";
            foreach(string s in MyFunctions.CreateWorkList(journals_path)) {
                listBox_j_w_l.Items.Add(s);
            }
        }


    }
}


