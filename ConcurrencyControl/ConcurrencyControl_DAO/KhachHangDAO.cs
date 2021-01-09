using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyControl_DAO
{
    public class KhachHangDAO : DBConnect
    {
        private static KhachHangDAO _instance = null;

        public static KhachHangDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new KhachHangDAO();
                }

                return _instance;
            }
        }
    }
}
