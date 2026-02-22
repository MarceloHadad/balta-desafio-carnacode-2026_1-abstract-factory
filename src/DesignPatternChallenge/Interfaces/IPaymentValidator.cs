namespace DesignPatternChallenge.Interfaces;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}
