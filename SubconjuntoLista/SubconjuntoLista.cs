using System;
using System.Collections.Generic;

class SubconjuntoLista
{
    static void Main()
    {
        String[] array = { "1","2","3"};
        List<List<String>> subsets = GeneradorSub(array);

        Console.WriteLine("Subconjuntos posibles:");
        foreach (List<String> subset in subsets)
        {
            Console.WriteLine($"[{string.Join(", ", subset)}]");
        }
    }

    static List<List<String>> GeneradorSub(String[] array)
    {
        List<List<String>> result = [];
        ConjuntoPotencia(array, 0, [], result);
        return result;
    }

    static void ConjuntoPotencia(String[] array, int index, List<String> set, List<List<String>> result)
    {
        // Agregar el subconjunto actual a la lista de resultados   
        result.Add(new List<String>(set));

        // Generar subconjuntos recursivamente
        for (int i = index; i < array.Length; i++)
        {
            // Agregar el elemento actual al subconjunto
            set.Add(array[i]);

            // Llamada recursiva para generar subconjuntos con el elemento actual
            ConjuntoPotencia(array, i + 1, set, result);

            // Eliminar el elemento actual para probar otros subconjuntos
            set.RemoveAt(set.Count - 1);
        }
    }
}