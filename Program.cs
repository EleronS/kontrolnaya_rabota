//  Написать программу, которая из имеющегося массива строк формирует новый
// массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

int N=3;
System.Console.WriteLine($"Введите {N} строк(и): ");
string[] t;
t= new string[N];
for(int i=0;i<N;i++)
t[i]=Console.ReadLine();
string[] m= new string[N];

void ArrayO(string[]t,string[]m)
{
   int k=0;
   for(int i=0;i<N;i++)
   {
    foreach(char c in t[i])
    {
       k++;
    }
      if(k<=3)
       m[i]= t[i];
        
    k=0;
}
}

void PrintArr(string[]m)
{
    System.Console.Write("Строки с значением три или менее символов:  ");
    for(int i=0;i<m.Length;i++)
         System.Console.Write($"{m[i],5}");
}
ArrayO(t,m);
System.Console.WriteLine();
PrintArr(m);
