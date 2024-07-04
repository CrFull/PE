using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulinha03_04_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, valor3, resultado, opcao;
            bool fim = false;

            while (fim == false) 
            { 
                //Usarei o mesmo programa para fazer os diferentes algoritmos(LISTA 01)

                Console.WriteLine("\n\nDigite o número da questão que deseja ver a execução.");
                Console.WriteLine("\n1. Ler dois valores numéricos. Calcular e apresentar o produto entre eles." +
                    "\n\n2. Ler três valores numéricos. Calcular e apresentar a média entre eles." +
                    "\n\n3. Ler um valor e escrever o seu antecessor." +
                    "\n\n4. Ler a idade de uma pessoa expressa em anos, meses e dias e escrever a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias." +
                    "\n\n5. Ler a idade de uma pessoa. Calcular e apresentar a existência desta pessoa em número de dias, em número de horas, em número de minutos e em número de segundos. Considerar ano com 365 dias e mês com 30 dias." +
                    "\n\n6. Ler uma temperatura em graus Fahrenheit e apresenta-la convertida em graus Celsius. A fórmula de conversão é C = ( F – 32 ) * ( 5 / 9 ), sendo F a temperatura em Fahrenheit e C a temperatura em Celsius." +
                    "\n\n7. Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 12 KM por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto (TEMPO) e a velocidade média (VELOCIDADE) durante a viagem. Desta forma, será possível obter a distância percorrida com a fórmula DISTÂNCIA = TEMPO * VELOCIDADE. Possuindo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula LITROS_USADOS = DISTÂNCIA / 12. Ao final o programa deve apresentar os valores da velocidade média (VELOCIDADE), tempo gasto na viagem (TEMPO), a distância percorrida (DISTÂNCIA) e a quantidade de litros (LITROS_USADOS) utilizada na viagem." +
                    "\n\n8. Efetuar o cálculo e a apresentação do valor de uma prestação em atraso, utilizando a fórmula PRESTAÇÃO = VALOR + (VALOR * (TAXA / 100) * TEMPO)." +
                    "\n\n9. Ler dois valores (inteiros, reais ou caracteres) para as variáveis A e B, e efetuar a troca dos valores de forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados." +
                    "\n\n10. Elaborar um programa que calcule e apresente o volume de uma caixa retangular por meio da fórmula VOLUME = COMPRIMENTO * LARGURA * ALTURA." +
                    "\n\n11. Efetuar a leitura de um número inteiro e apresentar o resultado do quadrado desse número" +
                    "\n\n12. Ler as 4 notas escolares de um aluno. Calcular e apresentar a média aritmética do aluno." +
                    "\n\n13. Ler a idade de duas pessoas. Calcular e apresentar a diferença das idades." +
                    "\n\n14. Ler de um vendedor o salário fixo, o valor total de vendas por ele efetuadas na loja e o percentual de comissão que ganha pelas vendas. Calcular e apresentar o valor da comissão que ele vai receber e o salário total." +
                    "\n\n15. Calcular a área de um triângulo. O programa deve ler o valor da base e o valor da altura do triângulo. A fórmula da área é: area = (base * altura) / 2. Após o cálculo apresentar a área." +
                    "\n\n16. Sabendo que uma milha marítima equivale a um mil, oitocentos e cinquenta e dois metros e que um quilômetro possui mil metros, converter milhas marítimas em quilômetros." +
                    "\n\n17. Entrar via teclado com o valor da cotação do dólar e uma certa quantidade de dólares. Calcular e exibir o valor correspondente em Reais (R$)." +
                    "\n\n18. Entrar via teclado com o valor de cinco produtos. Após as entradas, digitar um valor referente ao pagamento da somatória destes valores. Calcular e exibir o troco que deverá ser devolvido." +
                    "\n\n19. Dado o raio de uma esfera, calcular o seu volume e mostrar o resultado. Considere o valor de π = 3,1415. (volume = 4/3 * πR3)" +
                    "\n\n20. Ler o número total de eleitores de um município, o número de votos brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em relação ao total de eleitores." +
                    "\n\n21. O custo de um carro novo ao consumidor é a soma do custo de fábrica com a porcentagem do distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual do distribuidor seja de 28% e os impostos de 45%, ler o custo de fábrica de um carro, calcular E escrever o custo final ao consumidor.");
                Console.WriteLine("\n\nPara sair, digite 0.");
                opcao = receberValores("Digite uma opção: ");

                switch (opcao)
                {
                    default:
                        Console.WriteLine("\n\nDigite alguma opção.");
                        msgFinal();
                        break;
                    case 1:
                        //Questão 1
                        Console.WriteLine("1-Somar dois valores.");
                        valor1 = receberValores("Digite o primeiro número: ");
                        valor2 = receberValores("Digite o segundo número: ");
                        resultado = valor1 + valor2;

                        Console.WriteLine("\n\nA soma dos dois valores é: {0}", resultado);
                        msgFinal();
                        break;

                    case 2:
                        //Questão 2
                        Console.WriteLine("\n\n2-Produto de dois valores.");
                        valor1 = receberValores("Digite o primeiro número: ");
                        valor2 = receberValores("Digite o segundo número: ");
                        resultado = valor1 * valor2;

                        Console.WriteLine("\nO produto dos dois valores é: {0}", resultado);
                        msgFinal();
                        break;

                    case 3:
                        //Questão 3
                        Console.WriteLine("\n\n3-Média de três valores.");
                        valor1 = receberValores("Digite o primeiro número: ");
                        valor2 = receberValores("Digite o segundo número: ");
                        valor3 = receberValores("Digite o terceiro número: ");

                        resultado = (valor1 + valor2 + valor3) / 3;

                        Console.WriteLine("\nA média dos valores é: {0}", resultado);
                        msgFinal();
                        break;

                    case 4:
                        //Questão 4

                        Console.WriteLine("\n\n4-Ler um valor e escrever o seu antecessor.");
                        valor1 = receberValores("Digite um número: ");

                        resultado = valor1 - 1;

                        Console.WriteLine("\nO antecessor do valor é: {0}", resultado);
                        msgFinal();
                        break;

                    case 5:
                        //Questão 5-Terminar

                        Console.WriteLine("\n\n5-Ler uma data(dia/mes/ano) e retornar a idade em dias.");
                        valor1 = receberValores("Digite o dia: ");
                        valor2 = receberValores("Digite o mÊs: ");
                        valor3 = receberValores("Digite o ano: ");

                        resultado = 30 - valor1 + ((12 - valor2) * 30) + ((2023 - valor3) * 365);

                        Console.WriteLine("\nA sua idade em dias é: {0}", resultado);
                        msgFinal();
                        break;

                    case 6:

                        //Questão 6

                        Console.WriteLine("\n\n6-Ler uma temperatura em graus Fahrenheit e apresenta-la convertida em graus Celsius.");
                        valor1 = receberValores("Digite uma temperatura em Graus Celsius: ");

                        resultado = (valor1 - 32) * (5 / 8);

                        Console.WriteLine("\nA temperatura em Grau Celsius é: {0}", resultado);
                        msgFinal();
                        break;
                   
                    case 7:
                        //Questão 7
                        double litros;
                        Console.WriteLine("\n\n7-Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem. Digite o tempo gasto e a velocidade média respectivamente.");
                        valor1 = receberValores("Digite o tempo gasto na viagem: ");
                        valor2 = receberValores("Digite a velocidade média respectivamente: ");
                        resultado = valor1 * valor2;
                        litros = resultado / 12;
                        Console.WriteLine("\nA velocidade média é {0};\nO tempo gasto é {1};\nA distância percorrida é {2};\nLitros usados: {3}; ", valor1, valor2, resultado, litros);
                        msgFinal();
                        break;

                    case 8:
                        //Questão 8
                        Console.WriteLine("\n\n8-Prestação em atraso. Digite o valor, a taxa e o tempo, respectivamente.");
                        valor1 = receberValores(" Digite o valor da prestação: ");
                        valor2 = receberValores("Digite a taxa: ");
                        valor3 = receberValores("Digite uma opção: ");
                        resultado = valor1 + (valor1 * (valor2 / 100) * valor3);

                        Console.WriteLine("\nA A prestação é {0}", resultado);
                        msgFinal();
                        break;

                    case 9:
                        //Questão 9
                        String valorA, valorB;
                        Console.WriteLine("\n\n9-Ler dois valores (inteiros, reais ou caracteres) para as variáveis A e B, e efetuar a troca dos valores");
                        Console.WriteLine("\nDigite o valor de A:");
                        valorB = Console.ReadLine();
                        Console.WriteLine("\nDigite o valor de B:");
                        valorA = Console.ReadLine();


                        Console.WriteLine("\nO valor de A é {0};\nO valor de B é {1}", valorA, valorB);
                        msgFinal();

                        break;

                    case 10:
                        //Questão 10
                        Console.WriteLine("\n\n10-Calcule e apresente o volume de uma caixa retangular. Digite o comprimento, a largura e a altura, respectivamente. ");
                        valor1 = receberValores("Comprimento: ");
                        valor2 = receberValores("Largura: ");
                        valor3 = receberValores("Altura: ");
                        resultado = valor1 * valor2 * valor3;

                        Console.WriteLine("\nO volume da uma caixa é {0}", resultado);
                        msgFinal();

                        break;

                    case 11:
                        //Questão 11
                        Console.WriteLine("\n\n11-Efetuar a leitura de um número inteiro e apresentar o resultado do quadrado desse número.");
                        valor1 = receberValores("Digite um número inteiro: ");
                        resultado = Math.Pow(valor1, 2);

                        Console.WriteLine("\nO volume da uma caixa é {0}", resultado);
                        msgFinal();
                        break;

                    case 12:

                        //Questão 12
                        double valor4;
                        Console.WriteLine("\n\n12-Ler as 4 notas escolares de um aluno. Calcular e apresentar a média aritmética do aluno.");
                        valor1 = receberValores("Primeira nota: ");
                        valor2 = receberValores("Segunda nota: ");
                        valor3 = receberValores("Terceira nota: ");
                        valor4 = receberValores("Quarta nota: ");

                        resultado = (valor1 + valor2 + valor3 + valor4) / 4;

                        Console.WriteLine("\nO volume da uma caixa é {0}", resultado);
                        msgFinal();
                        break;

                    case 13:
                        //Questão 13
                        Console.WriteLine("\n\n13-Ler a idade de duas pessoas. Calcular e apresentar a diferença das idades");
                        valor1 = receberValores("Primeira idade: ");
                        valor2 = receberValores("Segunda idade: ");

                        resultado = Math.Abs(valor1 - valor2);

                        Console.WriteLine("\nA diferença de idades é {0}", resultado);
                        msgFinal();
                        break;

                    case 14:
                        //Questão 14
                        Console.WriteLine("\n\n14-Ler de um vendedor o salário fixo, o valor total de vendas por ele efetuadas na loja e o\r\npercentual de comissão que ganha pelas vendas. Digite o salário, o total de vendas e o percentual de comissão, respectivamente.");
                        valor1 = receberValores("Salário: ");
                        valor2 = receberValores("Total de Vendas: ");
                        valor3 = receberValores("Percentual de comissão: ");

                        resultado = valor2 * valor3;
                        Console.WriteLine("\nO valor da comissão {0}", resultado);
                        resultado = valor1 + resultado;
                        Console.WriteLine("\nO salario total é {0}", resultado);
                        msgFinal();
                        break;

                    case 15:
                        //Questão 15
                        Console.WriteLine("\n\n15-Calcular a área de um triângulo. Inserir a base e a altura, respectivamente.");
                        valor1 = receberValores("Base do triângulo: ");
                        valor2 = receberValores("Altura do triângulo: ");

                        resultado = (valor1 * valor2) / 2;
                        Console.WriteLine("\nA área do Triângulo é: {0}", resultado);
                        msgFinal();
                        break;

                    case 16:
                        //Questão 16
                        Console.WriteLine("\n\n16-Converter Milhas Marítimas em Quilômetros.");
                        valor1 = receberValores("Digite as milhaes marítimas: ");

                        resultado = (valor1 * 1852) / 1000;
                        Console.WriteLine("\nO valor de Milhas Marítimas em Quilômetros é: {0}", resultado);
                        msgFinal();
                        break;

                    case 17:
                        //Questão 17
                        Console.WriteLine("\n\n17-Calcular e exibir o valor de Dolares correspondente em Reais (R$). Digite a cotação do dólar e a quantidade de dolares.");
                        valor1 = receberValores("Cotação do Dólar: ");
                        valor2 = receberValores("Quantidade de dolares: ");

                        resultado = valor1 * valor2;
                        Console.WriteLine("\nO valor digitado convertido em Reais  é: {0}", resultado);
                        msgFinal();
                        break;

                    case 18:
                        //Questão 18
                        double valor5, valor6;
                        Console.WriteLine("\n\n18-Calcular e exibir o troco de 5 produtos. Digite o valor dos 5 produtos e do pagamento, respectivamente.");
                        valor1 = receberValores("Valor do Primeiro produto: ");
                        valor2 = receberValores("Valor do Segundo produto: ");
                        valor3 = receberValores("Valor do Terceiro produto: ");
                        valor4 = receberValores("Valor do Quarto produto: ");
                        valor5 = receberValores("Valor do Quinto produto: ");
                        valor6 = receberValores("\nValor do pagamento: ");

                        resultado = valor6 - (valor1 + valor2 + valor3 + valor5 + valor5);
                        Console.WriteLine("\nO troco é: {0}", resultado);
                        msgFinal();
                        break;

                    case 19:
                        //Questão 19
                        Console.WriteLine("\n\n19-Calcular o volume da esfera.");
                        valor1 = receberValores("Digite o raio de uma esfera: ");

                        resultado = (4 / 3) * (Math.PI * Math.Pow(valor1, 3));
                        Console.WriteLine("\nO volume da esfera é: {0}", resultado);
                        msgFinal();
                        break;

                    case 20:
                        //Questão 20
                        Console.WriteLine("\n\n20-Calcular e exibir o percentual de votos brancos, nulos e válidos em relação ao total de eleitores.");
                        valor1 = receberValores("Digite número total de eleitores do município: ");
                        valor2 = receberValores("O número de votos brancos: ");
                        valor3 = receberValores("O número de votos nulos: ");
                        valor4 = receberValores("O número de votos válidos: ");

                        resultado = (valor2 * 100) / valor1;
                        Console.WriteLine("\nO percentual de votos brancos é: {0}", resultado);
                        resultado = (valor3 * 100) / valor1;
                        Console.WriteLine("\nO percentual de votos nulos é: {0}", resultado);
                        resultado = (valor4 * 100) / valor1;
                        Console.WriteLine("\nO percentual de votos válidos é: {0}", resultado);
                        msgFinal();
                        break;

                    case 21:
                        //Questão 21
                        Console.WriteLine("\n\n21-Calcular o custo de fábrica de um carro, e exibir o custo final ao consumidor.");
                        valor1 = receberValores("Digite o custo de fábrica: ");

                        resultado = valor1 + (valor1 * 28) / 100 + (valor1 * 45) / 100;
                        Console.WriteLine("\nO custo do carro para o consumidor é: {0}", resultado);
                        msgFinal();

                        break;

                    case 0:
                        //////////////////////////// FIM //////////////////////////////////////////
                        fim = true;
                        break;
              

                }
            }

    }

        static double receberValores(String mensagem)
        {
            double valor;
            Console.WriteLine("\n\n" + mensagem);
            valor = verificarDadoNumerico();
            return valor;
        }
        static double verificarDadoNumerico()
        {
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("\nDigite apenas números!");
            }
            return valor; 
        }

        static void msgFinal()
        {
            Console.WriteLine("\nDigite qualquer tecla para continuar.");
            Console.ReadKey();
        }





    }
}
