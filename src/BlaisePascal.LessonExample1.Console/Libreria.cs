using System.ComponentModel.Design;

public class Libreria

{

    public static void Main()

    {


        Console.WriteLine("Benvenuto nella libreria Easy Class 3E");

        Console.WriteLine("Inserisca il suo nome");

        string NomeCliente = Console.ReadLine();

        Console.WriteLine($"benvenuto {NomeCliente} è uno studente?(si/no)");

        string Studente = Console.ReadLine();
        Console.WriteLine("Alla domanda se è uno studente ha risposto " + Studente);







        Console.WriteLine("Inserisca se vuole farsi spedire i libri o ritiro se li vuole ritirare personalmente(spedizione/ritiro");

        string TipoConsegna = Console.ReadLine();

        Console.WriteLine("Inserisca il numero di libri acquistati");
        int numerolibricomprati = int.Parse(Console.ReadLine());

        Console.WriteLine("Inserisca il costo di un singolo libro");
        int costolibro = int.Parse(Console.ReadLine());







        int costospedizione = 5;









        int CostoTotale = costospedizione + numerolibricomprati * costolibro;

        if(TipoConsegna == "ritiro")
        {
            CostoTotale = numerolibricomprati * costolibro;
        }

        if (CostoTotale <= 0)
        {
            Console.WriteLine("Errore: Ordine non valido");
        }
        if (CostoTotale <= 10)
        {
            Console.WriteLine("Ordine di piccolo importo");
        }

        else
        {
            Console.WriteLine("Grazie per l'ordine");
        }

        if (TipoConsegna == "spedizione")
        {
            Console.WriteLine($"Il costo totale dell'ordine è {CostoTotale} euro, con un costo di spedizione incluso nel prezzo di {costospedizione} euro, l'ordine sarà segnato a nome {NomeCliente}, il costo unitario è {costolibro} euro, sono stati ordinati {numerolibricomprati} libri ");
        }
        else if (TipoConsegna == "ritiro")
        {
            Console.WriteLine($"Il costo totale dell'ordine è {CostoTotale} euro, l'ordine sarà disponibile per il ritiro personalel'ordine sarà segnato a nome {NomeCliente}, il costo unitario è {costolibro} euro, sono stati ordinati {numerolibricomprati} libri ");
        }
        else
        {
            Console.WriteLine("Errore: Tipo di consegna non valido");







        }

    }
}
