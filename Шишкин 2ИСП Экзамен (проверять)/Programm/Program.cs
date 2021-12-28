// See https://aka.ms/new-console-template for more information
int[] R = new int[25];
Random rand = new Random();
for (int i = 0; i < 25; i++)
{
    R[i] = rand.Next(-100, 100);
    Console.WriteLine(R[i]);
}
double[] R2 = new double[25];
for (int i = 0; i < 25; i++)
{
    if (R[i] < 0)
    {
        R2[i] = Math.Pow(R[i], 2);
    }
    if (R[i] > 0)
    {
        R2[i] = R[i] + 7 ;
    }
    Console.WriteLine(R2[i]);
}