/*
    void FillArray(int[] collection)
    {
        int lenght = collection.Length;
        int index = 0;
        while (index < lenght)
        {
            collection[index] = new Random().Next(1, 10);
            index++;
        }
    }

    void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while(position < count){
            Console.WriteLine(col[position]); // Вывод массива, с новой строки
            position++;
        }
    }


    int[] array = new int[10]; //Создание нового массива в котором будет 10 элементов. По умалчанию наполнен 0.

    FillArray(array);
    PrintArray(array);
*/


void FillArray(int[] collection) // Заполнение массива случайными числами
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // Вывод массива, в строку через пробел
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //Создание нового массива в котором будет 10 элементов. По умалчанию наполнен 0.

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);