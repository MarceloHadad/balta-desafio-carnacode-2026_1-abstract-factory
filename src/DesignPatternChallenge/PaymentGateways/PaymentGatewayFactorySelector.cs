using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.PaymentGateways.MercadoPago;
using DesignPatternChallenge.PaymentGateways.PagSeguro;
using DesignPatternChallenge.PaymentGateways.Stripe;

namespace DesignPatternChallenge.PaymentGateways;

public static class PaymentGatewayFactorySelector
{
    public static IPaymentGatewayFactory From(string gateway)
    {
        switch (gateway.ToLower())
        {
            case "pagseguro": return new PagSeguroGatewayFactory();
            case "mercadopago": return new MercadoPagoGatewayFactory();
            case "stripe": return new StripeGatewayFactory();
            default: throw new ArgumentException("Gateway não suportado");
        }
    }
}
