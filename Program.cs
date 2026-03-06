using System;

class Program
{
    static List<string> stringhe = ["prova 1", "prova 2", "prova 3"];
    static void Main()
    {
        {

            bool continua = true;
            while (continua)
            {
                Console.WriteLine("\nScegli opzione:");
                Console.WriteLine("1 - Crea prodotti");
                Console.WriteLine("2 - Cancella prodotti");
                Console.WriteLine("3 - Modifica prodotti");
                Console.WriteLine("4 - Stampa Elenco prodotti");
                Console.WriteLine("5 - Esporta CSV prodotti");
                Console.WriteLine("0 - Esci");
                Console.Write("Scelta: ");
                int scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        // CreaProdotti();
                        break;
                    case 2:
                        // CancellaProdotti();
                        break;
                    case 3:
                        // ModificaProdotti();
                        break;
                    case 4:
                        // StampaElenco();
                        break;
                    case 5:
                        // ExportCsv(stringhe);
                        EsportaProdotti(stringhe);
                        break;
                    case 0:
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Scelta non valida!");
                        break;
                }
            }
            Console.WriteLine("Programma terminato.");
        }
    }

    public static void EsportaProdotti(List<String> stringhe)
    {
        string percorso = "prodotti.csv";

        using (StreamWriter sw = new StreamWriter(percorso))
        {
            // intestazione CSV
            sw.WriteLine("Nome");
            foreach (string s in stringhe)
            {
                sw.WriteLine(s);
            }
        }
        Console.WriteLine("File CSV creato con successo!");
    }
}