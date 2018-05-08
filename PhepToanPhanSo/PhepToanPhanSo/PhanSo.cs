using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhepToanPhanSo
{
    class PhanSo
    {
        int tuso, mau;
        public PhanSo()
        { 
            tuso = 0;
            mau = 1;
        }

        public PhanSo(int tuso, int mau)
        {
            this.tuso = tuso;
            this.mau = (mau == 0) ? 1 : mau;
        }

        public int Tuso
        {
            get { return tuso; }
            set { tuso = value; }
        }
        public int Mauso
        {
            get { return mau; }
            set { mau = value; }
        }
        private void ToiGian()
        {
            int us = lopdungchungcs.UCLN(tuso, mau);
            if (us > 0)
            {
                tuso /= us;
                mau /= us;
            }
        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * p.mau + p.tuso * mau;
            kq.mau = mau * p.mau;
            kq.ToiGian();
            return kq;
        }
        public PhanSo Tru(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * p.mau - p.tuso * mau;
            kq.mau = mau * p.mau;
            kq.ToiGian();
            return kq;
        }
        public PhanSo Nhan(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * p.tuso ;
            kq.mau = mau * p.mau;
            kq.ToiGian();
            return kq;
        }
        public PhanSo Chia(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuso = tuso * p.mau;
            kq.mau = mau * p.tuso;
            kq.ToiGian();
            return kq;
        }
    }
}
