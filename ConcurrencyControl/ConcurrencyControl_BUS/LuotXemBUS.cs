using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcurrencyControl_DAO;

namespace ConcurrencyControl_BUS
{
    public class LuotXemBUS
    {
        private static LuotXemBUS _instance = new LuotXemBUS();
        public static LuotXemBUS Instance
        {
            get
            {
                return _instance;
            }
        }

        public void AddViewing(string houseId, string cusId, string comment, DateTime date)
        {
            LuotXemDAO.Instance.AddViewing(houseId, cusId, comment, date);
        }

        public void AddViewingFixed(string houseId, string cusId, string comment, DateTime date)
        {
            LuotXemDAO.Instance.AddViewingFixed(houseId, cusId, comment, date);
        }
    }
}
