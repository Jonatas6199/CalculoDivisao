Console.WriteLine("Escreve o primeiro número da divisão: ");
double primeiroNumeroConvertido = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escreve o segundo número da divisão: ");
string segundoNumero = Console.ReadLine();
double segundoNumeroConvertido = Convert.ToDouble(segundoNumero);

double resultado = primeiroNumeroConvertido / segundoNumeroConvertido;
Console.WriteLine("Resultado da divisão: " + resultado.ToString("0.00"));
