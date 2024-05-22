using System;

class Program
{
    static void Main()
    {
        // Utworzenie tablicy liczb losowych o rozmiarze 100
        Random random = new Random();
        int[] arr = new int[100];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 100); // Generowanie liczb losowych od 1 do 100
        }

        // Wybór wartości poszukiwanej
        int targetValue = 50; // Przykładowa wartość poszukiwana

        // Ustawienie wartości poszukiwanej jako wartownika na końcu tablicy
        arr[arr.Length - 1] = targetValue;

        // Wyszukiwanie liniowe z wartownikiem
        int index = LinearSearchWithSentinel(arr, targetValue);
        if (index == -1)
        {
            Console.WriteLine("Element nie został znaleziony.");
        }
        else
        {
            Console.WriteLine($"Element znaleziony na pozycji: {index}");
        }
    }

    static int LinearSearchWithSentinel(int[] arr, int targetValue)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == targetValue)
            {
                return i; // Zwrócenie indeksu, jeśli element jest równy wartości poszukiwanej
            }
        }
        return -1; // Zwrócenie -1, jeśli element nie został znaleziony
    }
}