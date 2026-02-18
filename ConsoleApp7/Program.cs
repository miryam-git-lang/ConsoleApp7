class Program
{
	public static void Main(string[] args)
	{

		Card debitCard = new DebitCard();

		debitCard.Id = 87654;
		debitCard.Balance = 10000;
		debitCard.CardNumber = "1234567812345678";
		debitCard.Bank = BankName.LeoBank;


		string masked = debitCard.CardNumber.MaskCardNumber();

		Console.WriteLine(masked);
	}
}
