using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class STK_BUS
    {
        STK_DAO stk_dao = new STK_DAO();

        //public DataTable getThanhVien()
        //{
        //    return stk_dao.getThanhVien();
        //}
        public List<LOAITIETKIEM> getLoaiTietKiem()
        {
            return stk_dao.LoaiTK();
        }
        public bool themSTK(SOTIETKIEM stk)
        {
            return stk_dao.themSoTietKiem(stk);
        }

        public bool themKH(KHACHHANG kh)
        {
            return stk_dao.themKhachHang(kh);
        }

        //public bool xoaThanhVien(int TV_ID)
        //{
        //    return dalThanhVien.xoaThanhVien(TV_ID);
        //}

    }
}
