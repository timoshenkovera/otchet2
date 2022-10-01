Console.Write("Введите массив данных через ',': ");
string strLine = Console.ReadLine();
string[] inArr = strLine.Split(",");
string[] outArr = new string[0];

for (int i = 0; i < inArr.Length; i++)
{
    if (inArr[i].Length <= 3)
    {
        Array.Resize(ref outArr, outArr.Length + 1);
        outArr[outArr.Length-1] = inArr[i];
    }

}
Console.WriteLine($"[{string.Join(",", inArr)}]=>[{string.Join(",", outArr)}]");