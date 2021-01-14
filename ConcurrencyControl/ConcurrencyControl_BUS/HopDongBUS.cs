using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcurrencyControl_DAO;

namespace ConcurrencyControl_BUS
{
    public class HopDongBUS
    {
        private static HopDongBUS _instance = new HopDongBUS();
        public static HopDongBUS Instance
        {
            get
            {
                return _instance;
            }
        }

        public DataTable GetAllContracts()
        {
            DataTable result;

            result = HopDongDAO.Instance.GetAllContracts();

            return result;
        }

        public DataTable GetContractByIDFixed(string id)
        {
            DataTable result;

            result = HopDongDAO.Instance.GetContractByIDFixed(id);

            return result;
        }

        public DataTable GetEmployees()
        {
            return HopDongDAO.Instance.GetEmployees();
        }

        public DataTable GetContractByID(string id)
        {
            DataTable result;

            result = HopDongDAO.Instance.GetContractByID(id);

            return result;
        }

        public void UpdateEndDate(string id, DateTime newDate)
        {
            ConcurrencyControl_DAO.HopDongDAO.Instance.UpdateEndDate(id, newDate);
        }
    }
}
