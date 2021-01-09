using System;
using System.Collections.Generic;
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
    }
}
