//  Verificador de Palíndromos

Console.WriteLine("Digite uma palavra para verificar se é um palíndromo: ");
string palavra = Console.ReadLine();

string correcao = palavra.Replace(" ", "").ToLower();

string reverso = "";

for(int i = correcao.Length - 1; i >= 0; i--)
{
    reverso += correcao[i];
}

if(correcao == reverso)
{
    Console.WriteLine($"{palavra} é um palíndromo");
}

else
{
    Console.WriteLine($"{palavra} não é um palíndromo");
}