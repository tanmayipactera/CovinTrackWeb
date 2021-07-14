using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using VaccineEntites;
using System.Configuration;

namespace DAL
{
    public class VaccineDBAccess
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcs"].ToString());
        SqlCommand cmd;
        public string AddVaccinatedRecord(BEL be)
        {
            
            cmd = new SqlCommand("InsertVaccinated", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_code", be.emp_code);
            cmd.Parameters.AddWithValue("@Vaccine_Type", be.Vaccine_Type);
            cmd.Parameters.AddWithValue("@Dose_No", be.Dose_No);
            cmd.Parameters.AddWithValue("@Vaccine_Date", be.Vaccine_Date);
            cmd.Parameters.AddWithValue("@Vaccine_Location", be.Vaccine_Location);
            cmd.Parameters.AddWithValue("@Vaccine_Certificate", be.Vaccine_Certificate);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return ("Data saved Successfully");


        }

        //public string AddVaccinatedRecord(VaccineEntites vaccineEntites)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("InsertVaccinated", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@emp_code",vaccineEntites.emp_code);
        //        cmd.Parameters.AddWithValue("@Vaccine_Type", vaccineEntites.Vaccine_Type);
        //        cmd.Parameters.AddWithValue("@Dose_No", vaccineEntites.Dose_No);
        //        cmd.Parameters.AddWithValue("@Vaccine_Date", vaccineEntites.Vaccine_Date);
        //        cmd.Parameters.AddWithValue("@Vaccine_Location", vaccineEntites.Vaccine_Location);
        //        cmd.Parameters.AddWithValue("@Vaccine_Certificate", vaccineEntites.Vaccine_Certificate);
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        return ("Data saved Successfully");

        //    }

        //    catch(Exception ex)
        //    {
        //        if (con.State == ConnectionState.Open)
        //        {
        //            con.Close();
        //        }
        //        return (ex.Message.ToString());
        //    }
    }
    }
}
