using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable See_View(string _So, string _Duong, string _Phuong, string _Quan, string _TP)
        {
            DataTable result;

            result = LuotXemDAO.Instance.See_View(_So, _Duong, _Phuong, _Quan, _TP);
            return result;
        }

        public DataTable See_View_Fixed(string _So, string _Duong, string _Phuong, string _Quan, string _TP)
        {
            DataTable result;

            result = LuotXemDAO.Instance.See_View_Fixed(_So, _Duong, _Phuong, _Quan, _TP);
            return result;
        }

        public void AddViewing(string houseId, string cusId, string comment, DateTime date)
        {
            LuotXemDAO.Instance.AddViewing(houseId, cusId, comment, date);
        }

        public void AddViewingDL(string houseId, string cusId, string comment, DateTime date)
        {
            LuotXemDAO.Instance.AddViewingDL(houseId, cusId, comment, date);
        }

        public void AddViewingFixed(string houseId, string cusId, string comment, DateTime date)
        {
            LuotXemDAO.Instance.AddViewingFixed(houseId, cusId, comment, date);
        }

        public Tuple<DataTable, int> GetViewingOfCustomer(string id)
        {
            return LuotXemDAO.Instance.GetViewingOfCustomer(id);
        }

        public Tuple<DataTable, int> GetViewingOfCustomerFixed(string id)
        {
            return LuotXemDAO.Instance.GetViewingOfCustomerFixed(id);
        }

        public void DeleteViewing(string id, DateTime date)
        {
            LuotXemDAO.Instance.DeleteViewing(id, date);
        }

        public void AddViewingWithoutWait(string houseID, string cusID, string comment, DateTime date)
        {
            LuotXemDAO.Instance.AddViewingWithoutWait(houseID, cusID, comment, date);
        }

        public Tuple<DataTable, int> GetViewingOfHouse(string houseID)
        {
            return LuotXemDAO.Instance.GetViewingOfHouse(houseID);
        }

        public Tuple<DataTable, int> GetViewingOfHouseFixed(string houseID)
        {
            return LuotXemDAO.Instance.GetViewingOfHouseFixed(houseID);
        }
    }
}
