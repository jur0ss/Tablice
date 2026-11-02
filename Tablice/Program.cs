// See https://aka.ms/new-console-template for more information

Tablica t = new Tablica(50);
t.WyswietlElementy();
t.WyszukajElement(120);

t.WyswietlNieparzyste();
t.PoliczSrednia();

public class Tablica
{
    private int[] calkowite = [];

    public Tablica(int a)
    {
        calkowite = new int[a];    
        var random = new Random();
        
        for (int i = 0; i < a; i++)
        {
            calkowite[i] = random.Next(1, 1001);    
        }
    }
    

    public void WyswietlElementy()
    {
        Console.WriteLine("Wszystkie elementy tablicy:");
        for (int i = 0; i < calkowite.Length; i++)
        {
            Console.WriteLine($"{i}: {calkowite[i]}");
        }
    }
    
    
    /*
     * nazwa metody: WyszukajElement
     * opis metody: Metoda wyszukuje w tablicy liczbę podaną w parametrze
     * parametr: liczba typu int
     *
     * zwracany typ i opis: brak
     * autor: Jerzy Gryz
     * 
     */

    public void WyszukajElement(int liczba)
    {
        var index = calkowite.IndexOf(liczba);
        if (index == -1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine($"Liczba {liczba} znaleziona pod indeksem: {index}");
        }
        

    }

    public void WyswietlNieparzyste()
    {
        var liczbaInstancji = 0;
        Console.WriteLine("Liczby nieparzyste: ");
        foreach (int liczba in calkowite)
        {
            if(liczba%2!=0)
            {
                Console.WriteLine($"{liczba}");
                liczbaInstancji++;
            }
        }
        Console.WriteLine($"Razem nieparzystych: {liczbaInstancji}");
    }

    public void PoliczSrednia()
    {
        Console.WriteLine($"Średnia wszystkich elementów: {calkowite.Average()}");
    }
}

