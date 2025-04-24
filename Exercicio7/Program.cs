int[] num = new int[10];

int soma = 0;

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"Informe o número {i + 1}: ");
    num[i] = int.Parse(Console.ReadLine() ?? "0");

    if(num[i] % 2 == 0)
    {
        soma += num[i];
    }
}

Console.WriteLine($"O resultado da soma dos números pares é: {soma}");