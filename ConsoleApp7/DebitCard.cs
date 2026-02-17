sealed class DebitCard : Card
{
    public override bool WithDraw(int takingSum)
    {
        if(Balance -  takingSum > 0)
            return true;
        else
            return false;
    }
}
