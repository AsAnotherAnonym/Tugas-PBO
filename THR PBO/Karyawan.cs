using System;

namespace SistemManajemenKaryawan
{
    class Karyawan
    {
        private string nama;
        private string id;
        private double gaji_pokok;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public double GajiPokok
        {
            get { return gaji_pokok; }
            set
            {
                if (value >= 0)
                    gaji_pokok = value;
            }
        }

        public virtual double hitungGaji()
        {
            return GajiPokok;
        }
    }

    class KaryawanTetap : Karyawan
    {
        private const double BonusTetap = 500000;

        public override double hitungGaji()
        {
            return GajiPokok + BonusTetap;
        }
    }

    class KaryawanKontrak : Karyawan
    {
        private const double PotonganKontrak = 200000;

        public override double hitungGaji()
        {
            return GajiPokok - PotonganKontrak;
        }
    }

    class KaryawanMagang : Karyawan
    {
        public override double hitungGaji()
        {
            return GajiPokok;
        }
    }
}
