
int[,] dados = new int[4,4];


for(int linha = 0; linha <=3 ; linha++)
{
    for(int coluna = 0;coluna<=3;coluna++)
    {
        Console.Write("Digite o Valor:");
        dados[linha,coluna] = int.Parse(Console.ReadLine());
    }
}





