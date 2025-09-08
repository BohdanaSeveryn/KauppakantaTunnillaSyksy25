using Microsoft.Data.Sqlite;
class Program
{
    static void Main(string[] args)
    {
        KauppaDB kauppaDB = new KauppaDB();
        while (true)
        {
            Console.WriteLine("Haluatko lisätä tuotteen (L), hakea tuotteen(H) vai Lopettaa(X)?");
            string? vastaus = Console.ReadLine();
            switch (vastaus)
            {
                case "L":
                    Console.WriteLine("Anna tuotteen nimi:");
                    string ? nimi = Console.ReadLine();
                    Console.WriteLine("Anna tuotteen hinta:");
                    int hinta = Convert.ToInt32(Console.ReadLine());
                    //Lisätään tuote tietokantaan
                    kauppaDB.LisaaTuote(nimi, hinta);
                    break;
                case "H":
                case "X":
                    return;
                default:
                    Console.WriteLine("Väärä valinta. Anna L, H vai X");
                    break;
            }
        }
    }
}
