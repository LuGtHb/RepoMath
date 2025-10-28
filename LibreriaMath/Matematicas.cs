namespace LibreriaMath
{
    public static class Matematicas
    {
        public static int Sumatorio(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            return suma;
        }
    }
}
