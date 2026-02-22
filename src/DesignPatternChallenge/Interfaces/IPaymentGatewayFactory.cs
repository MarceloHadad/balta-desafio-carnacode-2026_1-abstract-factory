namespace DesignPatternChallenge.Interfaces;

public interface IPaymentGatewayFactory
{
    string GatewayName { get; }

    IPaymentValidator CreateValidator();
    IPaymentProcessor CreateProcessor();
    IPaymentLogger CreateLogger();
}
