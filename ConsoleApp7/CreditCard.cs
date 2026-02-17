sealed partial class CreditCard : Card
{
    int _limit;
    int Limit
    {
        get
        { 
            return Limit;
        }

        set
        {
            if (_limit >= 0)
                Console.WriteLine("Limit 0-DateAndTime asagi ola bilmez");
            else
                Limit = value;
        }
    }

    public override bool WithDraw(int takingSum)
    {
        if(Balance >= takingSum)
        {
            Balance -= takingSum;
            return true;
        }
        else if(Balance + Limit >= takingSum)
        {
            takingSum -= Balance;
            Limit -= takingSum;
            return true;
        }
        return false;
                    
    }
}