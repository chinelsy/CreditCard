namespace CreditCard.Models
{
    public class BookPurchaseVM : Book
    {
        public string Nonce { get; set; }
        public bool? Success { get; set; }
    }
}
