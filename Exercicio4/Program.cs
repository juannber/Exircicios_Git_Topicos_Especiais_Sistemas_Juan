// Conversor de Temperaturas com Menu


while(true) {

    double C, F;

    Console.WriteLine("Conversão de Temperatura");
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("Digite a opção desejada: ");
    int escolha = Convert.ToInt32(Console.ReadLine());

    switch(escolha){
        case 1: 
        Console.WriteLine("Informe a temperatura em Celsius: ");
        C = Convert.ToDouble(Console.ReadLine());
        
        F = (C * 9/5) + 32;

        Console.WriteLine($"A temperatura convertida para Fahrenheit é de °{F}\n");
        break;

        case 2:
        Console.WriteLine("Informe a temperatura em Fahrenheit: ");
        F = Convert.ToDouble(Console.ReadLine());

        C = (F - 32) / 1.8;

        Console.WriteLine($"A temperatura convertida para Celsius é de {C}°");
        break;

        case 3:
        return 0;

        default:
        Console.WriteLine("Digite uma opção válida");
        break;
    }
}