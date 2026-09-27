//Solicite que o usuário digite o valor da compra e o valor pago. Exiba o valor do troco.

Console.Write("Digite o Valor pago: ");
double valorPago = Convert.ToDouble(Console.ReadLine());

Console.Write($"Digite o Valor do produto: ");
double valorProduto = Convert.ToDouble(Console.ReadLine());

double troco = valorPago - valorProduto;
Console.WriteLine($"valor do seu troco: {troco:N2}");
