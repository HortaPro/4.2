//Миронова Анастасия 22-ИСП-2/1
//4.2 Уровень высокий
//Вариант 4

int[,] mas = new int[5, 5];
Random r = new Random();
int rows = mas.GetUpperBound(0) + 1;
int[] result = { };

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows; j++)
    {
        mas[i, j] = r.Next(0, 100);
    }
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows; j++)
    {
        if (i < j)
        {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = mas[i, j];
            Console.Write(mas[i, j] + " ");
        }
    }
}
Console.WriteLine();

for (int i = 0; i < result.Length - 1; i++)
{
    for (int j = 0; j < result.Length - i - 1; j++)
    {
        if (result[j] > result[j + 1])
        {
            int x = result[j];
            result[j] = result[j + 1];
            result[j + 1] = x;
        }
    }
}
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}

