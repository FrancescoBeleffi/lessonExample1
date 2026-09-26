using System.ComponentModel.Design;

public class Program // questa è una classe

{ 
    //Metodo di entrata per esecuzione del codice

    public static void Main()

    {


        Console.WriteLine("Benvenuto nella libreria Easy Class 3E");
        
        string NomeCliente = Console.ReadLine();

        Console.WriteLine($"benvenuto {NomeCliente}");

       

        Console.WriteLine("Inserisci il tipo di spedizione");
        
        string TipoConsegna = Console.ReadLine();

        Console.WriteLine("Inserisci il numero di pacchi acquistati");
        int numeropacchicomprati = int.Parse(Console.ReadLine());






        int costospedizione = 5; // dichiarazione + assegnazione
        
        costospedizione = 10; // assegnazione

      


        string tipoConsegna = "Standard"; //dichiarazione


        int CostoTotale = costospedizione + numeropacchicomprati;

        // Stampa a video con concatenazione di stringhe e variabili
        Console.WriteLine("Il costo totale della cnsegna è di " + CostoTotale + "euro");
        // il simbolo $ equivale a mettere il + prima della variabile tipoConsegna
        Console.WriteLine($"Il tipo di consegna selezionato è { tipoConsegna}");





    }
     
}
