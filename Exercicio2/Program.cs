// Tabuada completa com laço

Console.WriteLine("Digite um número: ");
int? num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

for(int i = 0; i <= 10; i++) 
{
    int? resul = num * i;
    Console.WriteLine($"{num} X {i} = {resul}");
}