//Поиск числа в массиве и вывод его индекса

int[] array = { 1, 12, 31, 4, 33, 76, 84, 33 };
int n = array.Length;

int find = 33;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //Прервись
    }
    index++;
}