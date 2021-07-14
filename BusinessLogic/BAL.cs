using System;
using BusinessEntites;
using DAL;

namespace BusinessLogic
{
    public class BAL
    {
        VaccineDBAccess da = new VaccineDBAccess();
        public bool Register(BEL be)
        {
            bool status = false;
            da.Register(be);
            return status;
        }
    }
}
