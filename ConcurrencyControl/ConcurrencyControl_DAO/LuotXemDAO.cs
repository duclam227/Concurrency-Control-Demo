using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyControl_DAO
{
    public class LuotXemDAO : DBConnect
    {
        private static LuotXemDAO _instance = null;

        public static LuotXemDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LuotXemDAO();
                }

                return _instance;
            }
        }
    }
}
