// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] NewThreeSymbolArray (string[] givenArray)
{
    for (int i = 0, j = 0; i < givenArray.Length; i++)
    {
        string checkedSymbol = givenArray[i];
        string[] newArray = new string[j];
        if (checkedSymbol.Length <= 3)
        {
            newArray[j] = checkedSymbol;
            j++;
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
