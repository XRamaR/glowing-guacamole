using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKdemiaJEDEN
{
    /*przydatne skróty: 
     * alt+enter ("program mówi nam jak to co robimy zrobić lepiej")
     * ctrl+spacja (podpowiedź np. metody klasy)
     */
    class Program
    {
        static void Main(string[] args)
        {
            var rowerList = new List<Rower_Klauss>();
            //Rower_Klauss rowerA = new Rower_Klauss(); //tworzenie nowego obiektu klasy
            //var rowerA = new Rower_Klauss(); //to samo co linijke wyzej
            var rowerA = new Rower_Klauss(0.5f);  //to samo utworzenie co wyzej po wykosztaniu ALt+Enter
            var rowerB = new Rower_Klauss(0.8f);

            rowerList.Add(rowerA);
            rowerList.Add(rowerB);

            for (int i = 0; i < rowerList.Count; i++) //podwójnie tab po "for" dla prefixu. Wypisanie całej tablicy
            {
                Console.WriteLine(rowerList[i]);
            }

            foreach(var rower in rowerList) //jw
            {
                string msg = (rower != null) ? rower.ToString() : "nie ma roweru."; //jezeli rower to nie null to wartośc rowera to "nie ma roweru"
                Console.WriteLine(rower);
            }
            //Console.WriteLine("Rower dist: "+ rowerA.dist); //wyświetlanie tekstu i danych
            //Console.WriteLine($"Rower dist: {rowerA.dist}"); //j.w.
            //Console.WriteLine(rowerA); //test
            //Console.WriteLine("Rower dist: " + rowerA.dist.ToString()); //co zrobił kompilator linie wyżej

        }
    }
}
