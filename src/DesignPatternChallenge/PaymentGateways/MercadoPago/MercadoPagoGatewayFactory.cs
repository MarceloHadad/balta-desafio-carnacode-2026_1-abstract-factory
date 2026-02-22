
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.PaymentGateways.MercadoPago;

public class MercadoPagoGatewayFactory : IPaymentGatewayFactory
{
    public string GatewayName => "MercadoPago";

    public IPaymentValidator CreateValidator()
    {
        return new MercadoPagoValidator();
    }

    public IPaymentProcessor CreateProcessor()
    {
        return new MercadoPagoProcessor();
    }

    public IPaymentLogger CreateLogger()
    {
        return new MercadoPagoLogger();
    }
}
