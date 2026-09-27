//Solicite que o usuário digite o valor da compra e o valor pago. Exiba o valor do troco.

double valorPago = Convert.ToDouble(Console.ReadLine());
double valorProduto = Convert.ToDouble(Console.ReadLine());
double troco = valorPago - valorProduto;

Console.WriteLine($"Digite o Valor pago: {valorPago:N2}");
Console.WriteLine($"Digite o Valor do produto: {valorProduto:N2}");
Console.WriteLine($"valor do seu troco: {troco:N2}");
