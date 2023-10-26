using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp_Telekocsi
{
    internal class Program
    {
        static List<Auto> autok = new List<Auto>();
        static List<Igeny> igenyek = new List<Igeny>();
        static void Main(string[] args)
        {

            // 1. feladat

            StreamReader sr = new StreamReader(".\\DataSource\\autok.csv", Encoding.UTF8);

            sr.ReadLine();  // fejléc sor beolvasása

            while (!sr.EndOfStream)
            {
                string[] lines = sr.ReadLine().Split(";");

                Auto adatsor = new Auto(
                    lines[0],
                    lines[1],
                    lines[2],
                    (lines[3]),
                    int.Parse(lines[4])
                    );

                autok.Add(adatsor);

            }

            sr.Close();

            // 2. feladat

            Console.WriteLine("2. feladat: ");
            Console.WriteLine($"\t{autok.Count()} autós hirdet fuvart");

            // 3. feladat

            Console.WriteLine("3. feladat");



            int ferohelyekSzama = autok.Where(x => x.Indulas == "Budapest" && x.Cel == "Miskolc").Sum(x => x.Ferohely);

            Console.WriteLine($"Összesen {ferohelyekSzama} férőhelyet hirdettek az autósok Budapestről Miskolcra");

            // 4. feladat

            Console.WriteLine("4. feladat");

            var legtobbFerehelyesUtak = autok
                .GroupBy(x => new { x.Indulas, x.Cel })
                .Select(group => new { 
                Utvonal = $"{group.Key.Indulas} - {group.Key.Cel}",
                OsszesFerohely = group.Sum(x => x.Ferohely)
                })
                .OrderByDescending(group => group.OsszesFerohely)
                .FirstOrDefault();

            Console.WriteLine($"A legtöbb férőhelyet ajánlották fel az útvonalon: {legtobbFerehelyesUtak}");

            // 5. feladat

            Console.WriteLine("5. feladat");

            StreamReader srIgenyek = new StreamReader(".\\DataSource\\igenyek.csv");

            srIgenyek.ReadLine(); // fejléc sor beolvasása

            while(!srIgenyek.EndOfStream)
            {
                string[] lines = srIgenyek.ReadLine().Split(";");

                Igeny adatsor = new Igeny(
                    lines[0],
                    lines[1],
                    lines[2],
                    int.Parse(lines[3])
                    );

                igenyek.Add(adatsor);
            }

            srIgenyek.Close();

            foreach (var igeny in igenyek)
            {
                foreach (var auto in autok)
                {
                    if(igeny.Indulas == auto.Indulas && igeny.Cel == auto.Cel)
                    {
                        Console.WriteLine($"{igeny.Azonosito} => {auto.Rendszam}");
                    }
                }
            }


        }
    }
}