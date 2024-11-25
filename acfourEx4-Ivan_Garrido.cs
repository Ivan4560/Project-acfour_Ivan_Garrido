using System;

public class emmagatzemarententers
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

        // Mostrar els nombres introduïts
        Console.WriteLine("Els nombres que has introduït són: ");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"Nombre {i + 1}: {nombres[i]}");
        }
    }
}
