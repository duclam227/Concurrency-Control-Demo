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

        public DataTable GetHouseOwners()
        {
            return NhaDAO.Instance.GetHouseOwners();
        }

        public Tuple<DataTable, float, int> CalculateAverageRentPrice()
        {
            return NhaDAO.Instance.CalculateAverageRentPrice();
        }

        public DataTable GetTypes()
        {
            return NhaDAO.Instance.GetTypes();
        }

        public DataTable GetAllHouses()
        {
            DataTable data = NhaDAO.Instance.GetAllHouses();
            return data;
        }

        public Tuple<DataTable, float, int> CalculateAverageRentPriceFixed()
        {
            return NhaDAO.Instance.CalculateAverageRentPriceFixed();
        }

        public DataTable GetBranches()
        {
            return NhaDAO.Instance.GetBranches();
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

<<<<<<< Updated upstream
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

        public DataTable GetAHouseData_Fix(string id)
        {
            DataTable result;

            result = NhaDAO.Instance.GetAHouseData_Fix(id);
            return result;
        }

        public DataTable ShowListHouse()
        {
            DataTable result;
            result = NhaDAO.Instance.ShowListHouse();
            return result;
        }

        public void Update_DL(string _id, DateTime _newdate)
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
=======
        public void AddHouse(string manha, string maln, string machunha, int slphong, int loaigd, float gia, string dieukien, string sonha, string duong, string phuong, string quan, string tp, DateTime ngayhethan)
        {
            NhaDAO.Instance.AddHouse(manha, maln, machunha, slphong, loaigd, gia, dieukien, sonha, duong, phuong, quan, tp, ngayhethan);
>>>>>>> Stashed changes
        }
    }
}
