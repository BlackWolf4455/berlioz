Random rnd = new Random();
double[] mas = new double[4];
double max=0;
double min = 10000;
for (int i = 0; i< mas.Length;i++)
{
    mas[i] = rnd.Next(-10,10);
    Console.Write("{0}, ", mas[i]);
    if(max<mas[i]) max = mas[i];
}
   Console.WriteLine("max={0}, ", max);