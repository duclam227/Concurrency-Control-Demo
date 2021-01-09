using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcurrencyControl_DAO;

namespace ConcurrencyControl_BUS
{
    public class LuotXemDAO
    {
        private static LuotXemDAO _instance = new LuotXemDAO();
        public static LuotXemDAO Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
