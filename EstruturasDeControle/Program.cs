#region Positivo ou Negativo
/* var numero = 10;
Console.WriteLine($"Vamos verificar se o numero {numero} é positivo ou negativo");
if (numero > 0)
{
    Console.WriteLine("Esse numero é positivo: ");
}
else
{
    Console.WriteLine("Esse numero é negativo: ");
}  */
#endregion

#region Temperaturas em Celsius - Utilizando if / else if / else
/* int temperatura;
Console.WriteLine("Informe um valor inteiro para representar um temperatura:");
temperatura = int.Parse(Console.ReadLine()!);
if(temperatura < 0)
{
Console.WriteLine("Temperatura Negativa");
}
else if (temperatura >= 0 && temperatura <= 30)
{
Console.WriteLine("Temperatura Amena");
}
else
{
Console.WriteLine("Temperatura Alta");
}
 */
#endregion

#region 2:Resultado do Número - Operador Ternário Aninhado
 int numero;

Console.Write("Informe um número inteiro: ");
numero = int.Parse(Console.ReadLine()!);
string resultado_numero = numero > 0 ? "positivo" :
numero < 0 ? "negativo" : "zero";
Console.WriteLine($"O tipo de número é '{resultado_numero}'!"); */

#endregion 

#region 3. Categoria - Uso do switch case
/* char opcao_menu;
Console.WriteLine("----Informe a opção desejada----");
Console.WriteLine("- A");
Console.WriteLine("- B");
Console.WriteLine("- C");
Console.WriteLine("- D");
Console.Write("Opção: ");
opcao_menu = Console.ReadKey().KeyChar;
switch (opcao_menu.ToString().ToUpper())
{
case "A": Console.WriteLine("\\nProduto Alimentício"); break;
case "B": Console.WriteLine("\\nProduto Bebida"); break;
case "C": Console.WriteLine("\\nProduto Limpeza"); break;
case "D": Console.WriteLine("\\nProduto Eletrônico"); break;
default: Console.WriteLine("\\nCategoria inválida"); break;
} */


#endregion









