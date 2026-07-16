Console.WriteLine("Informe o login e senha:");
string login = "admin";
string senha = "admin123";
string log;
string sen;

for (int i = 1; i < 4; i++)
{
    Console.WriteLine($"Sua {i}ª tentativa: ");
    Console.WriteLine("Informe o login: ");
    log = Console.ReadLine();
    Console.WriteLine("Informe a senha: ");
    sen = Console.ReadLine();
    if (login == log && senha == sen) {
        Console.WriteLine("Login realizado com sucesso!");
        break;
    } else
    {
        if (i == 3)
        {
            Console.WriteLine("Acesso bloqueado!");
        }
    }
}








/*string UsuarioRoot = "admin";
string SenhaRoot = "admin123";
int i = 0;


Console.WriteLine("Digite seu usuário: ");
string usuarioDigitado = Console.ReadLine();

Console.WriteLine("Digite sua senha: ");
string senhaDigitada = Console.ReadLine();

if(UsuarioRoot == usuarioDigitado &&
    SenhaRoot == senhaDigitada)
{    
    Console.WriteLine("Login realizado com sucesso.");
}
else
{ 
    i ++;
    if(UsuarioRoot != usuarioDigitado &&
    SenhaRoot != senhaDigitada)
    {
        Console.WriteLine("Usuario ou senha inválidos.");
        if(i == 3)
    {
    Console.WriteLine("Bloqueio de login.");
    }
}
*/