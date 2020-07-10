using System;
using System.Collections.Generic;
using System.Text;

namespace Secao6ComportamentoDeMemoriaArraysListas
{
    class ModificadorParametrosParams
    {
        public static void Main(string[] args)
        {
            //Instancia vetor de forma compacta e já insere os valores nele
            //com o params na função Sum() dispensa a necessidad de instanciar o vetor na chamada da funcao
            //int s1 = Calculator.Sum( 2, 3 );
            //int s2 = Calculator.Sum( 2, 4, 3 );

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);

            int a = 10;
            //palavra ref no parâmetro passa o valor da variável como referência
            // A palavra ref exige que a variável seja iniciada Ex: int a = 10;

            //Passagem por referencia afeta diretamente a variável com base
            //na posição da memória que ela se encontra

            //Passagem por valor é transferido apenas o valor da variável em questão
            //para o parâmetro da função chamada

            //Variaveis do tipo primitivo por padrão passam por valor
            //Objetos complexos passão por padrão via referencia à chamada do método


            Calculator.Triple(ref a);

            Console.WriteLine(a);
            // Console.WriteLine(retorno);

            classeteste obj = new classeteste();
            obj.nome = "teste";

            Console.WriteLine(obj.nome);
            Calculator.alteraNome(obj);
            Console.WriteLine(obj.nome);

        }
    }
}
