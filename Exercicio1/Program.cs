// Validador de Senhas Fortes

bool senhaValida = false;

while (!senhaValida) {

Console.WriteLine("Digite uma senha: ");
string? senha = Console.ReadLine();

bool letraMaiuscula = false;
bool numero = false;
bool especial = false;

foreach (char c in senha) {
   
    if(char.IsUpper(c))
    {
        letraMaiuscula = true;
    }

    else if(char.IsDigit(c))
    {
        numero = true;
    }

    else if(!char.IsLetterOrDigit(c))
    {
        especial = true;
    }
}

if(senha.Length >= 8 && letraMaiuscula && numero && especial)
    {
        Console.WriteLine("A senha digitada é forte!");
        senhaValida = true;
    }
    else 
    {
        Console.WriteLine("Senha inválida\nA senha deve conter:");
        Console.WriteLine("- Pelo menos 8 caracteres");
        Console.WriteLine("- Uma letra maiúscula");
        Console.WriteLine("- Um número");
        Console.WriteLine("- Um caractere especial");
    }
}