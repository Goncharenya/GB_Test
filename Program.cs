string[] strArray = new string[100];

Console.Write("Задайте кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = new string[n];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write("Введите элемент массива: ");
    myArray[i] = Convert.ToString(Console.ReadLine());
}

string[] array2 = new string[myArray.Length];

void SecondArray(string[] myArray, string[] array2)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= 3)
        {
            array2[count] = myArray[i];
            count++;
        }
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(array2[i]);
    }
}

Console.WriteLine(myArray);
SecondArray(myArray, array2);
ShowArray(array2);




