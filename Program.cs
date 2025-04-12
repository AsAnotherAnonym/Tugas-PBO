
using System;

namespace SistemManajemenKaryawan
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Tetap");
            Console.WriteLine("2. Kontrak");
            Console.WriteLine("3. Magang");
            Console.Write("Pilih jenis karyawan \t:");
            int jenis = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nama\t\t:");
            string nama = Console.ReadLine();

            Console.Write("Masukkan ID\t\t:");
            string id = Console.ReadLine();

            Console.Write("Masukkan gaji pokok\t:");
            double gaji = Convert.ToDouble(Console.ReadLine());

            Karyawan karyawan = null;

            if (jenis == 1)
            {
                karyawan = new KaryawanTetap();
            }
            else if (jenis == 2)
            {
                karyawan = new KaryawanKontrak();
            }
            else if (jenis == 3)
            {
                karyawan = new KaryawanMagang();
            }
            else
            {
                Console.WriteLine("Jenis karyawan tidak dikenali.");
                return;
            }

            karyawan.Nama = nama;
            karyawan.ID = id;
            karyawan.GajiPokok = gaji;

            Console.WriteLine($"\n--- Data Karyawan ---");
            Console.WriteLine($"Nama\t\t: {karyawan.Nama}");
            Console.WriteLine($"ID\t\t: {karyawan.ID}");
            Console.WriteLine($"Gaji Pokok\t: {karyawan.GajiPokok}");
            Console.WriteLine($"Gaji Akhir\t: {karyawan.hitungGaji()}");
        }
    }
}
