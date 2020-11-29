using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Sql;
using System.Data;

namespace DAO
{
    public class STK_DAO
    {
        private QuanlySoTietKiemEntities database = new QuanlySoTietKiemEntities();
        public bool themSoTietKiem(SOTIETKIEM stk)
        {
            database.SOTIETKIEMs.Add(stk);
            return false;
        }
        public bool themKhachHang(KHACHHANG KH)
        {
            database.KHACHHANGs.Add(KH);
            return false;
        }
        public List<LOAITIETKIEM> LoaiTK()
        {
            return database.LOAITIETKIEMs.ToList();
        }
    }
}
