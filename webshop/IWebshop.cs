namespace HemtentaTdd2017.webshop
{
    public interface IWebshop
    {
        ICart Cart { get; }
        void Checkout(IBilling billing);
    }
}