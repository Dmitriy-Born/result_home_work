Console.Write("Введите текст через запятую для проверки по длине элемента: ");
string[] text = Console.ReadLine()!.Split(',');
Console.WriteLine("Изначальный массив данных: ");


int count = 0;

int S = Quantity(text, count);
string[] Mass = new string[S];

//Метод подсчета количесвта элементов в массиве меньше или раные 3
int Quantity(string[] massive, int num)
{
    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i].Length <= 3)
        {
            num++;
        }
    }
    return num;
}
