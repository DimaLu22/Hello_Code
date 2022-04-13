int[] array = {1, 12, 31, 4, 15, 16, 17, 18};

int n = array.Length; //Узнаем сколько эллементов в массиве
int find = 4; //искомое число в массиве

int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; //добавляется если нужно найти только первый
    }
    index++;
}