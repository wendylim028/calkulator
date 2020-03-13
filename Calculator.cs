Class Calculator
{
		static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi Calculator");
            Console.WriteLine();
            Console.WriteLine("1.Penambahan");
            Console.WriteLine("2.Pengurangan");
            Console.WriteLine("3.Perkalian");
            Console.WriteLine("4.Pembagian");
            Console.WriteLine();
            Console.Write("Masukan Pilihan(1-4):");
            int pilihan = Int32.Parse(Console.ReadLine());

            if (pilihan > 0 && pilihan < 5)
            {
                Console.Write("Inputkan Nilai A = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan Nilai B = ");
                int b = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {
                    case 1:
                    Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
                    break;

                    case 2:
                    Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;

                    case 3:
                    Console.WriteLine("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;

                    case 4:
                    Console.WriteLine("Hasil Pengurangan: {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;

                }
            }
            else
            {
                Console.WriteLine("Tidak pilihan tidak tersedia");
            }

            Console.WriteLine();
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
}