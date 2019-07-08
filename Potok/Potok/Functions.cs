using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Potok
{
    static class MyFunctions
    {
        //static string journals_path = "d:\\Ruslan\\Potok\\";
        //static List<string> journals_work_list = CreateWorkList(journals_path);

        //Создание списка рабочих файлов журнала (в которых будем искать)
        //!!!добавить фильтр по дате
        public static List<string> CreateWorkList(string j_p) {
            List<string> j_w_l = new List<string>();
            if (j_p != null) {
                if (Directory.Exists(j_p)) {
                    string[] journals_dirs = Directory.GetDirectories(j_p);
                    foreach(string s in journals_dirs) {
                        string[] journals_list = Directory.GetFiles(s, "*.jrn");
                        foreach(string ss in journals_list) {
                            j_w_l.Add(ss);
                        }
                    }
                }
            }
            else {
                j_w_l.Add("Wrong path to journals!");
            }
            return j_w_l;
        }

        //Подключение к БД

    }
}
