string[] CreateArrray = {"one","two","three","four","five","1","12","123","1234"}; // Первый массив
string[] ThreeSymbols = CreateArrray;
for (int i = 0; i < ThreeSymbols.Count(); i++)
{
    if (ThreeSymbols[i].Length <= 3)
    {
        Console.WriteLine(ThreeSymbols[i]); //Вывод элементов
    }
}