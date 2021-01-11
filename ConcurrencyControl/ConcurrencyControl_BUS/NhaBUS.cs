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

        public Tuple<DataTable, int> GetSellingHouses(DateTime date)
        {
            Tuple<DataTable, int> result = NhaDAO.Instance.GetSellingHouses(date);

            return result;
        }

        public void ChangeToRent(string id)
        {
            NhaDAO.Instance.ChangeToRent(id);
        }

        public Tuple<DataTable, int> GetSellingHousesFixed(DateTime date)
        {
            Tuple<DataTable, int> result = NhaDAO.Instance.GetSellingHousesFixed(date);

            return result;
        }
    }
}
