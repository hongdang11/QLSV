﻿using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.BLL
{
    public class BLL_Lop
    {
        private static BLL_Lop instance;
        public static BLL_Lop Instance
        {
            get { if (instance == null) instance = new BLL_Lop(); return instance; }
            private set => instance = value;
        }
        private BLL_Lop() { }

        public DataTable DanhSach()
        {
            return BLL_Lop.Instance.DanhSach();
        }

        public bool Them(string malop, string tenlop, int soluong, string makhoa)
        {
            return BLL_Lop.Instance.Them(malop, tenlop, soluong, makhoa);
        }

        public bool Sua(string malop, string tenlop, int soluong, string makhoa, int id)
        {
            return BLL_Lop.Instance.Sua(malop, tenlop, soluong, makhoa, id);
        }

        public bool Xoa(int id)
        {
            return BLL_Lop.Instance.Xoa(id);
        }
    }
}