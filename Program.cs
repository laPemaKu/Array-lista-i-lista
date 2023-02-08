using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcija
{
    internal class Program
    {
        class Klasa
        {
            int godina;
            string prezime, ime;

            public Klasa(int godina, string prezime, string ime)
            {
                this.godina = godina;
                this.prezime = prezime;
                this.ime = ime;
            }

            public override string ToString()
            {
                string ispis = "Godina: " + this.godina + " Prezime: " + this.prezime;
                return ispis;
            }

            public int Godina { get => godina; set => godina = value; }
            public string Prezime { get => prezime; set => prezime = value; }
            public string Ime { get => ime; set => ime = value; }
            static void Main(string[] args)
            {
             /*   //defirniranje arrajliste
                ArrayList al = new ArrayList();

                //dummy varijable i objekt
                int broj = 1;
                string ime = "ime";
                bool provjera = false;
                Klasa objekt1 = new Klasa(2023, "Prezime");


                //dodavanje elementa u listu
                al.Add(objekt1);
                al.Add(provjera);
                al.Add(broj);
                al.Add(ime);

                //ispis elemenata
                for (int i = 0; i < al.Count; i++)
                {
                    Console.WriteLine(al[i]);
                }

                al.RemoveAt(2);

                //ispis elemenata
                Console.WriteLine("---Ispis nakon uklanjanja---");
                for (int i = 0; i < al.Count; i++)
                {
                    Console.WriteLine(al[i]);
                }

                al.Insert(2, broj);

                //ispis elemenata
                Console.WriteLine("---Ispis nakon insertanja---");
                for (int i = 0; i < al.Count; i++)
                {
                    Console.WriteLine(al[i]);
                }

                Console.ReadKey();
             */
                //List

                List<Klasa> lisata_objekata = new List<Klasa>();

                int godina;
                string prezime;
                string ime = "";

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Unesite godinu: ");
                    godina = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Unesite prezime: ");
                    prezime = Console.ReadLine();
                    Klasa objekt = new Klasa(godina, prezime, ime);

                    lisata_objekata.Add(objekt);
                }

                /*for(int i = 0; i < lisata_objekata.Count; i++)
                {
                    if (lisata_objekata[i].godina < 2023)
                    {
                        Console.WriteLine(lisata_objekata[i]);
                    }
                }
                */
                foreach(Klasa o in lisata_objekata)
                {
                    if(o.godina < 2023)
                    {
                        o.Ime = "Gabrijel";
                        Console.WriteLine(o.Prezime);
                        Console.WriteLine(o.Ime);
                    }
                }
                

                Console.ReadKey();
            }
        }
    }
}
