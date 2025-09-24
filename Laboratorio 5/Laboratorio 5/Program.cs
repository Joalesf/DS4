internal class Program
{
    private static void Main(string[] args)
    {
        // Declaración errónea en C#
        // int valores[];

        // Declaración válida
        int[] valores;                 // valores sin inicializar
        valores = new int[100];        // 100 elementos
        valores = new int[20];         // ahora contiene 20 elementos

        // Arreglos unidimensionales
        int[] valores1;                // sin inicializar
        int[] valores2 = new int[50];  // 50 elementos

        // Arreglos multidimensionales
        int[,] valores3;               // sin inicializar
        int[,] valores4 = new int[3, 7]; // matriz de 3x7
        int[,,] valores5 = new int[3, 4, 2]; // arreglo tridimensional

        // Arreglo de arreglos (jagged array)
        int[][] matriz = new int[3][]; // 3 filas
        for (int i = 0; i < matriz.Length; i++)
        {
            matriz[i] = new int[4]; // cada fila con 4 columnas
        }
    }
}