using Models.BussinessLogic.Constants;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.BussinessLogic.Parameter
{
    public static class LoginParameter
    {
        private const string PARAMETER_1 = "@uname";
        private const string PARAMETER_2 = "@pass";
        private const string PARAMETER_3 = "@grant";
        public static object[] Map(string @uname, string @pass, int @grant)
        {
            SqlParameter[] Parameter =
            {
                new SqlParameter(PARAMETER_1, @uname),
                new SqlParameter(PARAMETER_2, @pass),
                new SqlParameter(PARAMETER_3, @grant)
            };
            return Parameter;
        }
    }
}
