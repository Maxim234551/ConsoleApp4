using System;
using System.Text;
using System.IO;
namespace ConsoleApp4
{
    public class Indications
    {

        public string temperatyra;
        public string veter;
        public string skorost_vetra;


        public void Temperatyr(string temperatyra)
        {
            this.temperatyra = temperatyra;
        }
        public void Veter(string veter)
        {
            this.veter = veter;
        }
        public void Skorost_vetr(string skorost_vetra)
        {
            this.skorost_vetra = skorost_vetra;
        }
        public string Gettemperatyra()
        {
            return temperatyra;
        }
        public string Getveter()
        {
            return veter;
        }
        public string Getskorost_veter()
        {
            return skorost_vetra;
        }
        public Indications(string temperatyra_, string veter_, string skorost_vetra_)
        {
            Temperatyr(temperatyra_);
            Veter(veter_);
            Skorost_vetr(skorost_vetra_);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Savetemperatyra = "";
            string Saveveter = "";
            string Saveskorost_vetra = "";
            Console.WriteLine("Введите размер массива");

            int N = Convert.ToInt32(Console.ReadLine());
            while (N < 0)
            {
                Console.WriteLine("Ошибка, массив не может быть отрицательным");
                N = Convert.ToInt32(Console.ReadLine());
            }

            Indications[] IndicationsS = new Indications[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите температуру");
                Savetemperatyra = Console.ReadLine();

                Console.WriteLine("Введите направление ветра(vostok, zapad, sorth, north");
                Saveveter = Console.ReadLine();
                Console.WriteLine("Введите скорость ветра(мс)");
                Saveskorost_vetra = Console.ReadLine();
                IndicationsS[i] = new Indications(Savetemperatyra, Saveveter, Saveskorost_vetra);
                Console.WriteLine("Полученные данные");
                Console.WriteLine(Savetemperatyra);
                Console.WriteLine(Saveveter);
                Console.WriteLine(Saveskorost_vetra);




            }
        }
    }
}
