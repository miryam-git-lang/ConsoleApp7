public static class CardExtensions
{
	public static string MaskCardNumber(this string masked)
	{
		string maskedCardNumber = "";

		string startPart = masked.Substring(0, 4);
		string endPart = masked.Substring(12, 4);


		string middlePart = " **** **** ";

		maskedCardNumber = startPart + middlePart + endPart;

		return maskedCardNumber;


	}

	//public static double ExpenseWithBonus(this Card card, int sum)
	//{
	//	if (card.WithDraw(sum) == true)
	//	{
	//		switch (card.Bank)
	//		{
	//			case BankName.ABB:

	//				card.Bonus = sum * 1 + (2 / 100);

	//				return card.Bonus;

	//			case BankName.KapitalBank:

	//				card.Bonus = sum * 1 + (5 / 100);

	//				return card.Bonus;

	//			case BankName.LeoBank:

	//				sum = sum * 1 + (5 / 100);

	//				return card.Bonus;

	//		}
	//	}
	//}

}
