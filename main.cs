string[] arr1 = new string[5] {"Russia", "Denmark", "Kazan"};
string[] arr2 = new string[arr1.Length];

void ArrayFunc(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if(arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void ArrayPrint(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

ArrayFunc(arr1, arr2);
ArrayPrint(arr2);
