// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] NewThreeSymbolArray (string[] givenArray)
{
    int l = 1;
    string[] newArray = new string[l];
    for (int i = 0, j = 0; i < givenArray.Length; i++)
    {
        string checkedElement = givenArray[i];
        if (checkedElement.Length <= 3)
        {
            newArray[j] = checkedElement;
            j++;
            l = j;
        }
    }
    return newArray;
}

void PrintSimpleArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}; ");
    }
}

string[] CreateOriginalArray (string stringElement)
{
    string[] array = new string[stringElement.Length];
    array = stringElement.Split(";");
    return array;
}

System.Console.WriteLine("Enter elements and divide them by ';' :");
string lineOfSymbols = Console.ReadLine();
string[] originalArray = CreateOriginalArray(lineOfSymbols);
System.Console.WriteLine();

System.Console.WriteLine("Elements with 3 symbols ar less: ");
PrintSimpleArray(NewThreeSymbolArray(originalArray));
System.Console.WriteLine();