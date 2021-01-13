using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcurrencyControl_DAO;

namespace ConcurrencyControl_BUS
{
    public class NhaBUS
    {
        private static NhaBUS _instance = new NhaBUS();
        public static NhaBUS Instance
        {
            get
            {
                return _instance;
            }
        }

        public void UpdateEndDate(string id, DateTime newDate)
        {
            ConcurrencyControl_DAO.NhaDAO.Instance.UpdateEndDate(id, newDate);
        }

        public DataTable GetAHouseData(string id)
        {
            DataTable result;

            result = NhaDAO.Instance.GetAHouseData(id);
            return result;
        }

        public DataTable GetAHouseData_Fix (string id)
        {
            DataTable result;

            result = NhaDAO.Instance.GetAHouseData_Fix(id);
            return result;
        }

        public DataTable ShowListHouse ()
        {
            DataTable result;
            result = NhaDAO.Instance.ShowListHouse();
            return result;
        }

        public void Update_DL (string _id, DateTime _newdate)
        {
            ConcurrencyControl_DAO.NhaDAO.Instance.Update_DL(_id, _newdate);
        }

        public void Update_DL_Fix(string _id, DateTime _newdate)
        {
            ConcurrencyControl_DAO.NhaDAO.Instance.Update_DL_Fix(_id, _newdate);
        }

        public string SellHouse(string _id)
        {
            string _SDT;
            _SDT = ConcurrencyControl_DAO.NhaDAO.Instance.SellHouse(_id);

            return _SDT;
        }
    }
}
