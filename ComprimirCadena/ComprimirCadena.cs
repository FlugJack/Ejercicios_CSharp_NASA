using System;
using System.Text;

class ComprimirCadena
{
    static void Main()
    {
        string palabra = "aabbbssss";
        string palabracomprimida = ComprimirPalabra(palabra);
        Console.WriteLine("Cadena original: " + palabra);
        Console.WriteLine("Cadena comprimida: " + palabracomprimida);
    }

    static string ComprimirPalabra(string entrada)
    {
        
        StringBuilder cumprimido = new StringBuilder();
        char caracterActual = entrada[0];
        int contador = 1;

        for (int i = 1; i < entrada.Length; i++)
        {
            if (entrada[i] == caracterActual)
            {
                contador++;
            }
            else
            {
                cumprimido.Append(caracterActual);
                if (contador > 1)
                {
                    cumprimido.Append(contador);
                }
                caracterActual = entrada[i];
                contador = 1;
            }
        }

        cumprimido.Append(caracterActual);
        if (contador > 1)
        {
            cumprimido.Append(contador);
        }

        return cumprimido.Length < entrada.Length ? cumprimido.ToString() : entrada;
    }
}