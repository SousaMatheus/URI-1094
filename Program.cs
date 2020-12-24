using System;
using System.Globalization;

namespace URI_1094
{
    class Program
    {
        static void Main(string[] args)
        {
            //vamos fazer a leitura da quantidade de experimentos que serão feitos
            int qtdExperimentos = int.Parse(Console.ReadLine());
            //agora precisamos declarar as variaveis com um valor nulo para o compilador entender que a variavel existe e pode ser somada ao valor que será digitado
            int i = 0; //essa variável foi declarada para o loop do while que faremos
            int coelhos =0;
            int sapos =0;
            int ratos =0;
            do{
                string [] leituraCobaias = Console.ReadLine().Split(' '); //vamos fazer a leitura das cobaias e seu tipo em uma linha, usando o espaço em branco como divisor 
                int quantidade = int.Parse(leituraCobaias[0]); //variavel do tipo inteiro quantidade recebe o valor do vetor de string na posição 0 
                char tipoCobaia = char.Parse(leituraCobaias[1]);
                //para poder comparar o valor da variável com um caracter ou string precisa coloca-lo entre '' aspas simples
                if (tipoCobaia == 'C'){
                    coelhos = quantidade + coelhos;
                }
                else if (tipoCobaia == 'S'){
                    sapos = quantidade + sapos;
                }
                else {
                    ratos = quantidade + ratos;
                }               
               i ++; 
            }while(i < qtdExperimentos);
            
            int total = coelhos + sapos + ratos;
            double percentualCoelhos = (double)coelhos/ (double)total * 100.0;
            double percentualRatos = (double)ratos/ (double)total * 100.0;
            double percentualSapos = (double)sapos/ (double)total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos );
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + percentualCoelhos.ToString("F2",CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentualRatos.ToString("F2",CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentualSapos.ToString("F2",CultureInfo.InvariantCulture) + " %");
        }
    }
}
