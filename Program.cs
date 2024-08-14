
// //Tipos de variaveis
// int x = 10;
// double pi = 3.1415;
// char letra = 'M';
// bool isTrue = true;
// string texto = "Uma linda mensagem";
    
// double outroValor;
// //conversao implicita
// outroValor = x;
// //conversao explicita
// int valorInteiro = (int) pi;
    
// //conversao com a classe Convert 
// int y =Convert.ToInt32(texto);
// //Operadores
// //+,-,/,*, = , ==
// int numero;
// Console.WriteLine("Digite um numero:");
// numero = Convert.ToInt32(Console.ReadLine());
// //concatenação de strings
// Console.WriteLine("O usuario digitou: " + numero);
// //Interpolação de strings
// Console.WriteLine($"O dobro do que o usuário digitou é : {numero*2}");

double num1;
Console.WriteLine("Digite o primeiro número: ");
num1 = Convert.ToDouble(Console.ReadLine());
double num2;
Console.WriteLine("Digite o segundo número:");
num2 = Convert.ToDouble(Console.ReadLine());

double soma = num1+num2;
double subtracao = num1-num2;
double multiplicacao = num1*num2;
double divisao = num1/num2;

Console.WriteLine("A soma dos numero é igual " + soma);
Console.WriteLine($"A subtração dos numeros é igual {subtracao}");
Console.WriteLine(string.Format("A subtração dos números é igual {0}", multiplicacao));
Console.WriteLine(string.Format("A divisão dos números é igual {0}", divisao));

