#region Estruturas de repetição!
/* for (int i = 0; i < 10; i++) ;
{
    Console.WriteLine($"{i} - Varias mensangens\n");
}
 */
#endregion

#region Exercicio
/* int numero_tabuada;
Console.WriteLine("Informe um numero da tabuada que voce deseja ");
numero_tabuada = int.Parse(Console.ReadLine()!);

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero_tabuada} x {i} = {numero_tabuada} * 1\n");
}
 */
#endregion

#region Fibonácia

/* int numero1=0, numero2=1, soma=0, resultado=0;

 Console.WriteLine("0, ");

for (int i = 0; i <= 12; i++)
{
    resultado = numero2;
    soma = numero1 + numero2;
    numero1 = numero2;
    numero2 = soma;
    Console.WriteLine($"{resultado}");
}  */

#endregion

#region While


/* int numero;
Console.WriteLine("Digite um número positivo:");
numero = int.Parse(Console.ReadLine());
while (numero <= 0)
{
    Console.WriteLine("Número inválido! Digite um número positivo:");
    numero = int.Parse(Console.ReadLine());
} */

#endregion

#region Do While

/* char opcao;
char continuar;

do
{
    Console.WriteLine("------------------------------");
    Console.WriteLine(" Escola a opção ");
    Console.WriteLine("a) Somar");
    Console.WriteLine("b) Subtração");
    Console.WriteLine("opção: ");
    opcao = Console.ReadKey().KeyChar;


    while (opcao)
    {
        case 'a': Console.WriteLine("Somando Número "); break;
        case 'b': Console.WriteLine("Subtrair Número "); break;
        default : Console.WriteLine("Opção inválida"); break;
    
    }
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Voce pretendo continuar?\na) Sim \nb) Não");
} while (continuar == 'a'); */


#endregion

#region 4: Pedir para o usuário digitar um numero inteiro positivo e calcule o fatorial!
/* int resultado, fatorial = 1;
Console.WriteLine("Digite um numero positivo ");
resultado = int.Parse(Console.ReadLine()!);

for (i = 1; int <= fatorial; int++) ; */

#endregion