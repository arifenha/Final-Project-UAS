using System;
using Abstraction.Abstractclass;

namespace Abstractionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status = true;

            do
            {
                // clear console
                Console.Clear();

                // menampilkan selamat datang dan menu aplikasi
                Console.WriteLine("==================================================");
                Console.WriteLine("========== SELAMAT DATANG BENGKEL SAYA ===========");
                Console.WriteLine("==================================================");

                Console.WriteLine("");

                Console.WriteLine("Silahkan Pilih Menu Aplikasi: ");
                Console.WriteLine("1. Sperpart \n2. Service \n3. Tentang Aplikasi \n4. Keluar");

                Console.WriteLine("");

            // input pilihan
            InvalidOption:
                string opt;
                Console.Write("Masukkan Pilihan [1-4]: ");
                opt = Console.ReadLine();

                Bengkel bengkel;

                if (opt == "1")
                {
                    // exec function sparepart()
                    Sparepart();
                    
                }
                else if (opt == "2")
                {
                    // exec function service()
                    bengkel = new Service();
                    bengkel.Pesanan();
                }
                else if (opt == "3")
                {
                    // exec function tentang aplikasi()
                    AboutApp();
                }
                else if (opt == "4")
                {
                    // hanlde jika pilihan bernilai 5 / keluar
                    Console.WriteLine("Terima Kasih telah menggunakan program ini :)");

                    status = false;
                }
                else
                {
                    // handle data jika inputan tidak valid
                    Console.WriteLine("Pilihan tidak ada, silahkan masukkan lagi");
                    goto InvalidOption;
                }

            } while (status);

            static void Sparepart()
            {
                // menghapus / clear console
                Console.Clear();

                // menampilkan jenis karyawan
                Console.WriteLine("=====================================");
                Console.WriteLine("============ Sparepart ==============");
                Console.WriteLine("=====================================");
                Console.WriteLine("\nSilahkan Pilih Jenis Sparepart: ");


                Console.WriteLine("Maaf Sparepart dalam proses pengiriman");
                BalikMenu();

            }
            static void AboutApp()
            {
                // clear console
                Console.Clear();

                // menampilkan about app
                Console.WriteLine("=====================================");
                Console.WriteLine("============ ABOUT APP ==============");
                Console.WriteLine("=====================================");

                Console.WriteLine("\nNama & NIM       - Arif NUr Huda");
                Console.WriteLine("                 - Arsandi Wira Panorama  19.11.2822");
                Console.WriteLine("                 - Aresa Aulina Melinda   19.11.2808");
                Console.WriteLine("                 - Agel suprianto         19.11.2834");
                Console.WriteLine("                 - Galang pangestu        19.11.2849");
                Console.WriteLine("                 - Mohamad Jovan Nikola   19.11.2828");


                BalikMenu();
            }
            static void BalikMenu()
            {
                // Funtion untuk balik ke menu awal
                Console.WriteLine("\nTekan sembarang untuk kembali ke menu awal");
                Console.ReadKey();
            }
        }
    }
}
