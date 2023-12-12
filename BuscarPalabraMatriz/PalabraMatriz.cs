using System;
class PalabraMatriz
{
       static void Main()
    {
        char[,] sopa = {

            {'a', 'b','d','t','r',},
            {'a', 'r','b','o','l',},
            {'h', 'n','o','r','r',},
            {'a', 'a','b','o','l',},
            {'s', 'r','b','p','l',}

        };

    string palabra = "toro";

        bool encontrado = Buscador(sopa, palabra);

        if (encontrado)
        {
            Console.WriteLine($"La palabra '{palabra}' se encuentra en la matriz.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no se encuentra en la matriz.");
        }
    }

    static bool Buscador(char[,] matriz, string palabra)
    {
        int rows = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        // Recorremos cada celda de la matriz
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Comenzamos la búsqueda desde la celda actual
                if (ComprobarPalabra(matriz, palabra, i, j))
                {
                    return true; // La palabra se encontró
                }
            }
        }

        return false; // La palabra no se encontró en la matriz
    }

    static bool ComprobarPalabra(char[,] matriz, string palabra, int row, int col)
    {
        int rows = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        int len = palabra.Length;

        // Verificamos si la palabra cabe en la dirección horizontal hacia la derecha
        if (col + len <= cols)
        {
            bool coincide = true;
            for (int k  = 0; k < len; k++)
            {
                if (matriz[row, col + k] != palabra[k])
                {
                    coincide = false;
                    break;
                }
            }
            if (coincide)
                return true;
        }

        // Verificamos si la palabra cabe en la dirección vertical hacia abajo
        if (row + len <= rows)
        {
            bool coincide = true;
            for (int k = 0; k < len; k++)
            {
                if (matriz[row + k, col] != palabra[k])
                {
                    coincide = false;
                    break;
                }
            }
            if (coincide)
                return true;
        }

        // Verificamos si la palabra cabe en la dirección diagonal hacia abajo y a la derecha
        if (row + len <= rows && col + len <= cols)
        {
            bool coincide = true;
            for (int k = 0; k < len; k++)
            {
                if (matriz[row + k, col + k] != palabra[k])
                {
                    coincide = false;
                    break;
                }
            }
            if (coincide)
                return true;
        }

        // La palabra no se encontró en ninguna dirección
        return false;
    }

    
}