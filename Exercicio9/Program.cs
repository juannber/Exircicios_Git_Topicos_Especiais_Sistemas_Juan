/* Jogo da Adivinhação
Gere um número aleatório entre 1 e 100. Peça que o usuário tente adivinhar. Após cada
tentativa, informe se o número é maior ou menor. Conte o número de tentativas */

Random r = new Random();
int numero = r.Next(0, 101);

int tentativas = 0;
bool acerto = false;

Console.WriteLine("Adivinhe o número de 0 a 100");

while(acerto != true)
{
    Console.WriteLine("Digite sua tentativa:");
    int adv = int.Parse(Console.ReadLine() ?? "0");
    tentativas++;

    if(adv > numero)
    {
        Console.WriteLine("O número é menor!");
    }

    else if(adv < numero)
    {
        Console.WriteLine("O número é maior!");
    }

    else
    {
        Console.WriteLine($"Parabéns! Você acertou, o número era {numero}");
        Console.WriteLine($"Total de tentativas: {tentativas}");
        acerto = true;
    }
}