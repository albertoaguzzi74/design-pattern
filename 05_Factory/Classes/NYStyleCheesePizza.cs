namespace _05_Factory.Classes;

public class NYStyleCheesePizza : Pizza
{
    public NYStyleCheesePizza()
    {
        name = "NY Style Sauce and Cheese Pizza";
        dough = "Thin Crust Dough";
        sauce = "Marinara Sauce";

        toppings.Add("Grated Reggiano Cheese");
    }
}