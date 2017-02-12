namespace HemtentaTdd2017.webshop
{
    public interface IBilling
    {
        decimal Balance { get; }
        void Pay(decimal cost);
        decimal CalcOrder(ICart cart, IShipping shipping);
    }
}