
using System.Runtime.CompilerServices;

internal interface ICardService
{
	public void AddToArray(Card card);

}

class CardService : ICardService
{
    private static Card[] Cards = [];
    public void AddToArray(Card card)
    {
       Array.Resize(ref Cards, Cards.Length + 1);
        Cards[Cards.Length - 1] = card;
    }

    public Card this[string cardNumber]
    {
        get
        {
            foreach (Card card in Cards)
            {
                if(card.CardNumber == cardNumber)
                    return card;
            }

            return null;
        }
        
    }

	
}
