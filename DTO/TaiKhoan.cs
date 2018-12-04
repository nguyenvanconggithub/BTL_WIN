using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TaiKhoan
    {
        private string acc;
        private string pass;
        private Byte[] avatar;
        private bool isAdmin;



        public string Acc
        {
            get { return acc; }
            set { acc = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        
        public Byte[] Avatar { get { return avatar; } set { avatar = value; } }

        public bool IsAdmin { get { return isAdmin; } set { isAdmin = value; } }
    }
}
