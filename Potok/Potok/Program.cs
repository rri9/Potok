using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Potok
{
    class Program
    {
        static void Main(string[] args)
        {
            string journals_path = "d:\\Ruslan\\Potok\\";
            List<string> journals_work_list = CreateWorkList(journals_path);

            //Выводим список рабочих файлов
            if (journals_work_list!=null) {
                foreach (string s in journals_work_list) {
                    Console.WriteLine("  {0}", s);
                }
            }
        }

        //Создаем список рабочих файлов
        private static List<string> CreateWorkList(string j_p){
            if (Directory.Exists(j_p)){
                List<string> j_w_l = new List<string>();
                //Console.WriteLine("Path {0} exist!", j_p);
                string[] journal_dirs = Directory.GetDirectories(j_p);
                foreach (string s in journal_dirs){
                    string[] journals_list = Directory.GetFiles(s, "*.jrn");
                    //Console.WriteLine(s);
                    foreach (string ss in journals_list){
                        //Console.WriteLine("    {0}", ss);
                        j_w_l.Add(ss);
                    }
                }
                return j_w_l;
            }
            else{
                Console.WriteLine("Directory {0} doesn't exist", j_p);
                return null;
            }
        }
    }
}
