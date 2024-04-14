using System;
using tp_tpmodul8_1302220104;

class Program
{
    static void Main(string[] args)
    {
        covidConfig config = covidConfig.LoadConfig();

        config.UbahSatuan();

        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}");
        double suhuBadan = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman? ");
        double hariDeman = Convert.ToDouble(Console.ReadLine());

        bool kondisi1 = (config.SatuanSuhu == "celcius" && suhuBadan >= 36.5 && suhuBadan <= 37.5) ||
                        (config.SatuanSuhu == "fahrenheit" && suhuBadan >= 97.7 && suhuBadan <= 99.5);
        bool kondisi2 = hariDeman < config.BatasHariDeman;

        if (kondisi1 && kondisi2)
        {
            Console.WriteLine(config.PesanDiterima);
        }
        else
        {
            Console.WriteLine(config.PesanDitolak);
        }
    }
}
