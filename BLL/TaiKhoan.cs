using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class TaiKhoanBLL
    {
        private static TaiKhoanBLL instance;
        public static TaiKhoanBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanBLL();
                return instance;
            }


        }

        public TaiKhoanBLL() { }
        public DataTable getAccount()
        {
            return DataTaiKhoan.Instance.getAccount();

        }

        public void addAccount(TaiKhoan tk)
        {
            DataTaiKhoan.Instance.addAccount(tk);
        }

        public void delAccount(TaiKhoan tk)
        {
            DataTaiKhoan.Instance.delAccount(tk);
        }

        public TaiKhoan getInfoByID(string id)
        {
            return DataTaiKhoan.Instance.getInfoByID(id);
        }
        public bool check(string username, string pass)
        {

            return DataTaiKhoan.Instance.checkAcc(username, pass);
        }
    }
}
