using DesignPatternChallenge.PaymentGateways;
using DesignPatternChallenge.Services;

Console.WriteLine("=== Sistema de Pagamentos (Abstract Factory) ===\n");

var pagSeguroFactory = PaymentGatewayFactorySelector.From("pagseguro");
var pagSeguroService = new PaymentService(pagSeguroFactory);
pagSeguroService.ProcessPayment(150.00m, "1234567890123456");

Console.WriteLine();

var mercadoPagoFactory = PaymentGatewayFactorySelector.From("mercadopago");
var mercadoPagoService = new PaymentService(mercadoPagoFactory);
mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");

Console.WriteLine();

var stripeFactory = PaymentGatewayFactorySelector.From("stripe");
var stripeService = new PaymentService(stripeFactory);
stripeService.ProcessPayment(99.90m, "4234567890123456");

Console.WriteLine();

try
{
    PaymentGatewayFactorySelector.From("unknown");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
