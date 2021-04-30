using System;

namespace IdadeCompleta
{
    class Program
    {
        static void Main(string[] args)
        {
             Console . WriteLine ( " Qual é a sua idade? " );
            int  idadePessoa  =  int . Parse ( Console . ReadLine ());

            int  idadeMeses  =  idadePessoa  *  12 ;
            int  idadeDias  =  idadePessoa  *  365 ;
            int  idadeHoras  =  idadeDias  *  24 ;

            Console . WriteLine ( " Sua idade em meses é: "  +  idadeMeses );
            Console . WriteLine ( " Sua idade em dias é: "  +  idadeDias );
            Console . WriteLine ( " Sua idade em horas é: "  +  idadeHoras );
        }
    }
}
