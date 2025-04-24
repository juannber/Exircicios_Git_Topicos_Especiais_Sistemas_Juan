// Calculo de fatorial com while

Console.WriteLine("Informe um número: ");
int num = Convert.ToInt32(Console.ReadLine());

int contador = num;
int resultado = 1;

while(contador > 1)
{
    resultado *= contador;
    contador--;
}

Console.WriteLine($"{num}! = {resultado}");