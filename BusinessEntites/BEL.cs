using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace VaccineEntites
{
    public class BEL
    {
        public string emp_code { get; set; }
        public string Vaccine_Type { get; set; }
        public int Dose_No { get; set; }

        public string Vaccine_Date{ get; set; }

        public string Vaccine_Location { get; set; }

        public string Vaccine_Certificate { get; set; }

    }
}
