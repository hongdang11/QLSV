﻿using QLSV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.BLL
{
    public class BLL_MonHoc
    {
        private static BLL_MonHoc instance;
        public static BLL_MonHoc Instance
        {
            get { if (instance == null) instance = new BLL_MonHoc(); return instance; }
            private set => instance = value;
        }
        private BLL_MonHoc() { }

        public DataTable DanhSach()
        {
            return DAL_MonHoc.Instance.DanhSach();
        }

        public bool Them(string MaMH, string TenMH, string SoTC, int TietLT, int TietTH)
        {
            return DAL_MonHoc.Instance.Them(MaMH, TenMH, SoTC, TietLT, TietTH);
        }

        public bool Sua(string MaMH, string TenMH, string SoTC, int TietLT, int TietTH, int id)
        {
            return DAL_MonHoc.Instance.Sua(MaMH, TenMH, SoTC, TietLT, TietTH, id);
        }

        public bool Xoa(int id)
        {
            return DAL_MonHoc.Instance.Xoa(id);
        }

        internal bool Sua(string maMH, string tenMH, int soTC, int lT, int tH, int id)
        {
            throw new NotImplementedException();
        }

        internal bool Them(string maMH, string tenMH, int soTC, int lT, int tH)
        {
            throw new NotImplementedException();
        }
    }
}