using System.ComponentModel.Design;

public class Program // questa è una classe

{ 
    //Metodo di entrata per esecuzione del codice

    public static void Main()
    {
        Console.WriteLine("Benvenuto nella libreria Easy Class 3E");

        int costospedizione = 5; // dichiarazione + assegnazione
        
        costospedizione = 10; // assegnazione

        int numeropacchicomprati = 2;


        string tipoConsegna = "Standard"; //dichiarazione


        int CostoTotale = costospedizione + numeropacchicomprati;

        // Stampa a video con concatenazione di stringhe e variabili
        Console.WriteLine("Il costo totale della cnsegna è di " + CostoTotale + "€");
        // il simbolo $ equivale a mettere il + prima della variabile tipoConsegna
        Console.WriteLine($"Il tipo di consegna selezionato è { tipoConsegna}");





    }
     
}
