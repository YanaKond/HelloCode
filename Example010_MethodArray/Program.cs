int [] array = {17, 24, 65, 57, 89, 5431,674, 32};

int n = array.Length;
int find = 24;

int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}