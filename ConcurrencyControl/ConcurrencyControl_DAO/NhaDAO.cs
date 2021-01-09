using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyControl_DAO
{
    public class NhaDAO : DBConnect
    {
        private static NhaDAO _instance = null;

        public static NhaDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NhaDAO();
                }

                return _instance;
            }
        }
    }
}
