//Instancia New

Cliente _cli;
_cli = new Cliente();
_cli.idade = 25;
Console.WriteLine(_cli.idade);

_cli.idade = 50;
Console.WriteLine(_cli.idade);

public class Cliente
{
    public string cpf;
    public string nome;
    public string status;
    public int idade;
    public void ImprirIdade()
    {
        Console.Write(idade + "AN");
    }



}















  