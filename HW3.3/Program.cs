Console.WriteLine("Введите число N:");
int number =int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{ 
 Console.Write($"{i*i*i} ");
}

int ReadInt(string message)
{
 Console.Write(message);
 return int.Parse(Console.ReadLine());
}
