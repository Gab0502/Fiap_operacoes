try
{
    double num1=10;
    double num2=10;
    Console.WriteLine("Bem vindo");
    
    double soma = num1+num2;
    double sub = num1 - num2;
    double mult = num1 * num2;
    double modulo = num1 % num2;


    Console.WriteLine("\n comparação entre numeros");

    Console.WriteLine($"os numeros são iguais? {num1 == num2}");

    Console.WriteLine($"os numeros são diferentes? {num1 != num2}");

    Console.WriteLine($"o primeiro numero é maior que o segundo? {num1 > num2}");


    bool ambosPositivos = num1>0 && num2 > 0;
    bool nenhumNegativo = !(num1 < 0 && num2 < 0);

    Console.WriteLine($"Ambos positivos {ambosPositivos}");
    Console.WriteLine($"Nenhum numero negativo? {nenhumNegativo}");

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.ReadKey();