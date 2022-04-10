using System.Collections.Generic;
 public class GroceryIsle
    {
        public List<Fooditem> FoodList{ get; set;}
        public string isleName { get; set; }
        public int isleNum { get; set; }


    public GroceryIsle() => FoodList = new List<Fooditem>();

    public void AddFooditem(Fooditem fooditem)
{
    FoodList.Add(fooditem);
}
    }