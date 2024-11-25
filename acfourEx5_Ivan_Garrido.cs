using System;

public class EmmagatzemarEntersDescendentment
{
    public static void Main()
    {
        // Demanar a l'usuari quants nombres vol emmagatzemar
        Console.Write("Quants nombres naturals vols emmagatzemar? ");
        int quantitat;

        // Validar que l'entrada sigui un enter positiu
        while (!int.TryParse(Console.ReadLine(), out quantitat) || quantitat <= 0)
        {
            Console.Write("Si us plau, introdueix un nombre enter positiu: ");
        }

        // Crear un array per guardar els nombres
        int[] nombres = new int[quantitat];

        // Demanar els nombres naturals a l'usuari
        Console.WriteLine("Ara introdueix els nombres naturals:");
        for (int i = 0; i < quantitat; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out nombres[i]) || nombres[i] < 0)
            {
                Console.Write("Si us plau, introdueix un nombre natural (0 o superior): ");
            }
        }

        // Ordenar els nombres en ordre descendent
        Array.Sort(nombres); // Primer ordena en ordre ascendent
        Array.Reverse(nombres); // Després inverteix l'ordre

        // Mostrar els nombres ordenats
        Console.WriteLine("Els nombres que has introduït, ordenats de manera descendent, són:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"Nombre {i + 1}: {nombres[i]}");
        }
    }
}
