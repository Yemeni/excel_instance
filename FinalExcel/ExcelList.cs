using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyExcelApp
{
    class ExcelRecord
    {

        public string cdatetime { get; set; }
        public string beat { get; set; }
        public string address { get; set; }
        public string district { get; set; }
        public string grid { get; set; }
        public string crimedescr { get; set; }
        public string ucr_ncic_code { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }

    }

    class RecConstants
    {
        private const string DOMAIN_NAME = "xyz.com";
    }
}
