using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcurrencyControl_DAO;

namespace ConcurrencyControl_BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS _instance = new KhachHangBUS();
        public static KhachHangBUS Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
