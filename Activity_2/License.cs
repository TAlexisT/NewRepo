using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activity_2;
using System.Threading.Tasks;

namespace Activity_2
{
    internal class License
    {

        public int key_Code { get; set; }
        public string type { get; set; }
        public DateTime FIni { get; set; }
        public DateTime FFin { get; set; }
        public bool LicForm = false;

        public DateTime FBase = new DateTime(2022, 05, 30);

        public License Make_Lic(string type_Lic, DateTime F_In, DateTime F_Fi)
        {
            License Make_Lic2 = new License();
            Make_Lic2.type = type_Lic;
            Make_Lic2.FIni = F_In;
            Make_Lic2.FFin = F_Fi;
            if (Make_Lic2.FFin >= FBase)
            {
                Make_Lic2.LicForm = true;
            }

            return Make_Lic2;
        }
    }
}