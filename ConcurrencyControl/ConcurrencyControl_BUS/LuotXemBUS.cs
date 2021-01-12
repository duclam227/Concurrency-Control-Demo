﻿using System;
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

        public void AddViewing(string houseId, string cusId, string comment, DateTime date)
        {
            LuotXemDAO.Instance.AddViewing(houseId, cusId, comment, date);
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
    }
}