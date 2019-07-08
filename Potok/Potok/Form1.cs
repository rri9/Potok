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
            //Добавить опрос пути к каталогам у пользователя
            string journals_path = "d:\\Ruslan\\Potok\\";   //каталог по умолчанию
            List<string> j_w_l = MyFunctions.CreateWorkList(journals_path);
            foreach (string s in j_w_l) {
                listBox_j_w_l.Items.Add(s);
            }

            //открываем файл журнала
            string connectionString = (string) listBox_j_w_l.Items[0];
            
            label1.Text = connectionString; //debug

        }
    }
}


