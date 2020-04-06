using System;

namespace AB5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilkommen bei der Anzahl der vegangenen Tage im Jahr Rechner");
            Console.WriteLine("Geben Sie den Tag als nummer ein.");
            int tag = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Geben Sie den Monat als nummer ein.");
            int monat = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Geben Sie den Jahr als nummer ein.");
            int jahr = Convert.ToInt16(Console.ReadLine());
            int vergangenenTag = 0;
            switch (monat)
            {
                case 1:
                    vergangenenTag = 0;
                    break;
                case 2:
                    vergangenenTag = 31;
                    break;
                case 3:
                    vergangenenTag = 59;
                    break;
                case 4:
                    vergangenenTag = 90;
                    break;
                case 5:
                    vergangenenTag = 120;
                    break;
                case 6:
                    vergangenenTag = 151;
                    break;
                case 7:
                    vergangenenTag = 181;
                    break;
                case 8:
                    vergangenenTag = 212;
                    break;
                case 9:
                    vergangenenTag = 243;
                    break;
                case 10:
                    vergangenenTag = 273;
                    break;
                case 11:
                    vergangenenTag = 304;
                    break;
                case 12:
                    vergangenenTag = 334;
                    break;
                default:
                    Console.WriteLine("Eingabefeheler");
                    break;
            }
            /* evaluate leap year modifier */
            int leapYearMod = 0;
            int ist400 = (jahr % 400);
            int ist100 = (jahr % 100);
            int ist4 = (jahr % 4);
            if (ist400 == 0)
            {
                leapYearMod = 1;
            }
            else if (ist100 == 0)
            {
                leapYearMod = 0;
            }
            else if (ist4 == 0)
            {
                leapYearMod = 1;
            }
            else
            {
                leapYearMod = 0;
            }
            int anzahlVergangenTag = (tag + vergangenenTag + leapYearMod-2);
            Console.WriteLine("Der nummer des vergangenen Tage seite 1/1/{0} ist {1}", jahr, anzahlVergangenTag);
        }
    }
}
