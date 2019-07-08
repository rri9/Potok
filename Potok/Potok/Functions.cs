using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potok {
    static class MyFunctions {
        //static string journals_path = "d:\\Ruslan\\Potok\\";
        //static List<string> journals_work_list = CreateWorkList(journals_path);

        //Создание списка рабочих файлов журнала (в которых будем искать)
        //!!!добавить фильтр по дате
        public static List<string> CreateWorkList(string j_p) {
            List<string> j_w_l = new List<string>();
            j_w_l.Add("empty");
            return j_w_l;
        }

    }
}
