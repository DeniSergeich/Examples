int[] array = { 111, 92, 66, 41, 58, 66, 57, 58 };

int n = array.Length;
int find = 66;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}