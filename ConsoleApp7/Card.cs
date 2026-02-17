using Microsoft.VisualBasic;
using System.ComponentModel.Design;

abstract class Card
{
    public int Id;
    public int Balance;
    public int Bonus;

    public string _cardnumber;
    public string CardNumber
    {   get
        {
            return _cardnumber;
        }
        set
        {
            if (value.Length != 16)

                Console.WriteLine("Kartin nomresi mutleq 16 reqemnen olmalidir");

            else
                _cardnumber = value;
        }
            
    }

    
    public abstract bool WithDraw(int takingSum);
    public void MaskCard(Card CardNumber)
    {

        for (int i = 3; i < 12; i++)
        {
            CardNumber[i] = "*"
        }
       
    }
}
