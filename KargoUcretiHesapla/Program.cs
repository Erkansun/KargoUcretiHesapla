namespace KargoUcretiHesapla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Paketiniz kaç kg?: ");
            double kgAgirlik = Convert.ToDouble(Console.ReadLine());

            Console.Write("Paketiniz kaç km uzağa gönderilecek?: ");
            double kmUzaklik = Convert.ToDouble(Console.ReadLine());

            double baslangicFiyat = 100, kgFiyat = 5, kmFiyat = 1;

            double KargoFiyatiHesapla(double kg, double km)
            {
                return baslangicFiyat + (kg * kgFiyat) + (km * kmFiyat);
            }

            Console.WriteLine();

            Console.WriteLine($"Kargo gönderim ücetiniz: {KargoFiyatiHesapla(kg:kgAgirlik, km: kmUzaklik)} TL'dir");

            Console.ReadKey();
        }
    }
}
