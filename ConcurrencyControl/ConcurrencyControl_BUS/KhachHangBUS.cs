using System;
using System.Collections.Generic;
using System.Data;
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

        public void AddNew(string name, string addr, string phone, string sex, DateTime dob, int nhucau, string maln, string tieuchi, string chinhanh)
        {
            KhachHangDAO.Instance.AddNew(name, addr, phone, sex, dob, nhucau, maln, tieuchi, chinhanh);
        }

        public void AddNewFixed(string name, string addr, string phone, string sex, DateTime dob, int nhucau, string maln, string tieuchi, string chinhanh)
        {
            KhachHangDAO.Instance.AddNewFixed(name, addr, phone, sex, dob, nhucau, maln, tieuchi, chinhanh);
        }

        public DataTable GetAll()
        {
            return KhachHangDAO.Instance.GetAll();
        }
    }
}
