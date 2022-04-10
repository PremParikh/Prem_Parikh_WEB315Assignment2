public class Fooditem 
{
    public int quantity{ get; set;}
    public int code{ get; set;}
    public string? foodname { get; set;}
    public string? foodtype { get; set;}
    public int price{ get; set;}

    public void IncreaseQuantity()
    {
        if(quantity<20)
        quantity = quantity + 1;
    }

    public void DecreaseQuantity()
    {
        if(quantity>0)
        quantity = quantity - 1;
    }
}