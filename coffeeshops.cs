using System;
using System.IO;
//1
public class Character{

    private string worker_name;
    private string role; //barista, cashier, customer, manager

    
    public string name 
    {
        get { return worker_name; }
        set { worker_name = value; }
    }
    public string Role{
        get {return role;}
        set {role = value;}

    }
    
    public void mess_Role() 
    {
        role = Console.ReadLine();
         switch(role)

        {   case "customer":
                Console.WriteLine("Welcome!");
                break;
            case "cashier":
                Console.WriteLine("Please, take the customer's order!");
                break;
            case "barista":
                Console.WriteLine("Please, wait for the cashier's instruction");
                break;
            case "manager":
                Console.WriteLine("Here to establish order");
                break;
            default:
                Console.WriteLine("No such role!");
                break;
        }
    }

    public void mess_Name(){
        switch(worker_name)
        {
            case "Andrew":
                Console.WriteLine("Hello Barista Andrew!");
                role = "barista";
                break;
            case "Roberta":
                Console.WriteLine("Hello Cashier Roberta!");
                role = "cashier";
                break;
            case "Juan":
                Console.WriteLine("Hello Manager Juan");
                role = "manager";
                break;
            default:
                mess_Role();
                break;
        }
    }
    

}
//2
public class Beverage{
    private string beverage_name; //coffee, tea, h_choc
    private string type;

    public string beverage 
    {
        get { return beverage_name; }
        set { beverage_name = value; }
    }

    public string type_beverage
    {
        get { return type; }
        set { type = value; }
    }

    public void setBeverage(string beverage)
    {
        type = beverage;
    }
    public void descr()
    {
        switch(type)
        {
            case "tea":
            Console.WriteLine("What kind of tea would you like?");
            break;

            case "coffee":
            Console.WriteLine("What kind of coffee would you like?");
            break;

            case "hot chocolate":
            Console.WriteLine("Hot Chocolate to be!");
            break;

            case "cold drink":
            Console.WriteLine("What kind of drink would you like?");
            break;

            default: 
            Console.WriteLine("Sorry, we don't have such drink");
            break;
        }

    }
    
}
//3
public class Coffee{
    private string beans_type; //arabica, robusta, mixt
    private string coffee_type;
    private int price = 0;
    
    public void setPrice(int n){
        price = n;
    }
    
    public int getPrice(){
        return price;
    }
    
    public string beans
    {
        get {return beans_type;}
        set {beans_type = value;}
    }

    public string coffee
    {
        get {return coffee_type;}
        set {coffee_type = value;}
    }
    public void bean(string bean)
    {
        beans_type = bean;
    }
    public void coffee_bean()
    {
        switch(beans_type)
        {
            case "arabica":
                Console.WriteLine("\nSweet taste choice");
                break;
            case "robusta":
                Console.WriteLine("\nBitter taste choice");
                break;
            case "mixt":
                Console.WriteLine("\nBest choice");
                break;
        }
    }

    public void choose_coffee(string choice)
    {
       coffee_type =  choice;
    }
    public void choose()
    {   
        switch(coffee_type)
        {
            case "latte":
                Console.WriteLine("\nEspresso with milk to be!");
                setPrice(26);
                break;
            case "cappuccino":
                Console.WriteLine("\nEspresso with milk and foam to be!");
                setPrice(25);
                break;
            case "americano":
                Console.WriteLine("\nEspresso with water to be!");
                setPrice(23);
                break;
            case "espresso":
                Console.WriteLine("\nEspresso to be!");
                setPrice(20);
                break;
            case "doppio":
                Console.WriteLine("\nDouble espresso to be!");
                setPrice(25);
                break;
            case "mocha":
                Console.WriteLine("\nEspresso with chocolate and milk to be!");
                setPrice(25);
                break;
            case "flat white":
                Console.WriteLine("\nEpresso with milk to be!");
                setPrice(27);
                break;
            case "irish":
                Console.WriteLine("\nCoffee with wiskey, sugar and cream to be!");
                setPrice(32);
                break;
            case "macchiato":
                Console.WriteLine("\nEspresso with foam to be!");
                setPrice(24);
                break;
            default:
                Console.WriteLine("Sorry, we don't serve such coffee");
                Environment.Exit(0);
                break;
        }

    }
    
}
//4
public class Dessert{
    private string dessert_name;
    private int price = 0;
   
    public void setPrice(int n){
        price = n;
    }
    
    public int getPrice(){
        return price;
    }
    
    public string dessert
    {
        get { return dessert_name; }
        set { dessert_name = value; }
    }
    
    public void setDessert(){
        Console.WriteLine("\nChoose a dessert which you would want to get for yourself:\n");
        dessert_name = Console.ReadLine();
        switch(dessert_name){
            case "brownie":
                setPrice(35);
                break;
            case "classic cheesecake":
                setPrice(45);
                break;
            case "cherry cheesecake":
                setPrice(47);
                break;
            case "oreo cake":
                setPrice(40);
                break;
        }
        Console.WriteLine("\n"+dessert_name + " to be!\n");
    }
}
//5
public class Tea{
    private string tea_type;
    private int price = 0;
    
    public void setPrice(int n){
        price = n;
    }
    
    public int getPrice(){
        return price;
    }
    
    public string tea
    {
        get{return tea_type;}
        set{tea_type = value;}
    }

     public void choose_tea(string choice)
    {
       tea_type = choice;
    }
    public void choose()
    {
        tea_type = Console.ReadLine();
        switch(tea_type)
        {
            case "black":
                Console.WriteLine("\nBlack tea to be!");
                setPrice(20);
                break;
            case "green":
                Console.WriteLine("\nGreen tea to be!");
                setPrice(20);
                break;
            case "fruitty":
                Console.WriteLine("\nFruitty tea to be!");
                setPrice(25);
                break;
            case "herbal":
                Console.WriteLine("\nHerbal tea to be!");
                setPrice(20);
                break;
            case "ginger":
                Console.WriteLine("\nGinger tea to be!");
                setPrice(25);
                break;
            default: 
                Console.WriteLine("Sorry, we don't serve this tea.");
                Environment.Exit(0);
                break;
        }  
    }
}
//6
 public class Tips{
    private double money;

    public double tip
    {
        get {return money;}
        set{money = value;}
    }

    public void get_tips()
    {
        money = Convert.ToDouble(Console.ReadLine());
    }

 }
//7
public class Extra{
    private string extras;
    private int price = 0;
    
    public void setPrice(int n){
        price = n;
    }
    
    public int getPrice(){
        return price;
    }
    
    public string extra
    {
        get {return extras;}
        set {extras = value;}
    }
     public void adds(string add)
    {
       extras = add;
    }
    public void extra_beverage()
    {
        switch(extras)
        {
            case "sugar":
                Console.WriteLine("\nWhich sugar do you want to have? Brown or white?");
                String sugars = Console.ReadLine();
                switch(sugars)
                    {
                        case "white": 
                            Console.WriteLine("White sugar to be!");
                            break;
                        case "brown":
                            Console.WriteLine("Brown sugar to be!");
                            break;
                    }
                    setPrice(2);
            break; 
        
            case "syrup":
                Console.WriteLine("\nWe have caramel, vanilla, hazelnut and creme brulee syrup. Which one do you choose?");
                String type_syrup = Console.ReadLine();
                switch(type_syrup){
                    case "caramel":
                        Console.WriteLine("Caramel Syrup to be!");
                        break;
                    case "vanilla":
                        Console.WriteLine("Vanilla Syrup to be!");
                        break;
                    case "hazelnut":
                        Console.WriteLine("Hazelnut Syrup to be!");
                        break;
                    case "creme brulee":
                        Console.WriteLine("Creme Brulee Syrup to be!");
                        break;
                }
                setPrice(4);
                break;
            case "ice":
                Console.WriteLine("\nIce to be!");
                setPrice(2);
                break;
            case "milk":
                Console.WriteLine("\nWe have cow milk, almond milk, coconut milk and soya milk. Which one do you want to have?");
                String type_milk = Console.ReadLine();
                    switch(type_milk){
                        case "cow":
                            Console.WriteLine("Cow milk to be!");
                            setPrice(4);
                            break;
                        case "almond":
                            Console.WriteLine("Almond milk to be!");
                            setPrice(8);
                            break;
                        case "coconut":
                            Console.WriteLine("Coconut milk to be!");
                            setPrice(8);
                            break;
                        case "soya":
                            Console.WriteLine("Soya milk to be!");
                            setPrice(8);
                            break;
                    }
                break;
            case "sweetener":
                Console.WriteLine("\nSweetener to be!");
                setPrice(2);
                break;
            default: 
                Console.WriteLine("\nSorry, we don't have it!");
                break;
        }
    }
}
// //8
public class W_Time{ 
    private double time;
    
    public double WorkTime 
    {
        get {return time;}
        set {time = value;}
    }

    public void w_time(){
    if (8.00<=time && time<21.00)
    {
        Console.WriteLine("We are OPEN!");
    }
    else 
    {
        Console.WriteLine("Sorry, We are CLOSED!");
        Environment.Exit(0);
    }
    }

}
//9
public class Coldrinks{
    private string cold_drink;
    private int price = 0;
    
    public void setPrice(int n){
        price = n;
    }
    
    public int getPrice(){
        return price;
    }
    public string colds 
    {
        get{return cold_drink;}
        set{cold_drink = value;}
    }
    public void dcold(string temp_cold)
    {
        cold_drink = temp_cold;
    }
    public void choose_drink()
    {
        switch(cold_drink)
        {
            case "cola":
                Console.WriteLine("\nCola to be!");
                setPrice(25);
                break;
            case "fanta":
                Console.WriteLine("\nFanta to be!");
                setPrice(25);
                break;
            case "sprite":
                Console.WriteLine("\nSprite to be!");
                setPrice(25);
                break;
            case "water":
                Console.WriteLine("\nWater to be!");
                setPrice(20);
                break;
            case "sparkling water":
                Console.WriteLine("\nSparkling water to be!");
                setPrice(20);
                break;
            case "classic lemonade":
                Console.WriteLine("\nClassic lemonade to be!");
                setPrice(35);
                break;
            default:
                Console.WriteLine("\nSorry, we don't have it!");
                break;
        }
    }

}
 //10
public class Payment{
    private double pay;
    private string method;
    
    public double Money_pay
    {
        get {return pay;}
        set {pay = value; }
    }

    public string method_pay
    {
        get {return method;}
        set {method = value;}
    }

    public void pay_bill(int total)
    {
        Console.WriteLine("Which method are you choosing to pay the bill with? Cash or card?");
        method = Console.ReadLine();
        switch(method)
        {
            case "cash":
                Console.WriteLine("Your bill has a total of: "+ total + " lei.");

                break;
            case "card":
                Console.WriteLine("You paid "+total+" lei with your credit card.");
                break;

        }
    }
 }

class my_coffee_shop
{
    static public void Main()
    {
        int total = 0;
        Payment payment = new Payment();
        Console.WriteLine("\nTime is: ");
        W_Time time = new W_Time();
        time.WorkTime = Convert.ToDouble(Console.ReadLine());
        time.w_time();

        Console.WriteLine("\nCharacters details:");
        Character Obj = new Character();
        Obj.name = Console.ReadLine();
        Obj.mess_Name();
        //Obj.Role = Console.ReadLine();
        Console.WriteLine("Name: " + Obj.name + "\nOccupation: " + Obj.Role);
        //Obj.mess_Role();

        string aux;
        Beverage drink = new Beverage();
        Dessert dessert = new Dessert();
        Console.WriteLine("\nWhat would you like to drink?");
        aux = Console.ReadLine();
        drink.setBeverage(aux);
        drink.descr();

        string coff_temp, beans_temp;
        if (String.Equals("coffee", aux))
        {
            Coffee new_coffee = new Coffee();
            coff_temp = Console.ReadLine();
            new_coffee.choose_coffee(coff_temp);
            new_coffee.choose();
            Console.WriteLine("what beans you prefer for your coffee?");
            beans_temp = Console.ReadLine();
            new_coffee.bean(beans_temp);
            new_coffee.coffee_bean();
            total+=new_coffee.getPrice();
        }else if(String.Equals("tea",aux)){
            Tea tea = new Tea();
            tea.choose();
            total+=tea.getPrice();
        }
        if (aux == "coffee" || aux == "tea")
        {   
            string quest;
            string extra_temp;
            Console.WriteLine("\nWould you like something extra to the beverage?");
            quest = Console.ReadLine();
            if (quest =="Yes, please")
            {
                Extra extra_drink = new Extra();
                extra_temp = Console.ReadLine();
                extra_drink.adds(extra_temp);
                extra_drink.extra_beverage();
                total+=extra_drink.getPrice();
            }
        }
        Console.WriteLine("\nDo you want a dessert to the beverage?\n");
        string choice = Console.ReadLine();
        if(String.Equals(choice,"yes")){
            dessert.setDessert();
            total+=dessert.getPrice();
        }
            string tipq;
            Console.WriteLine("\nTips?");
            tipq = Console.ReadLine();
            if (tipq == "Yes, sure!")
            {
                Tips tipm = new Tips();
                tipm.tip = Convert.ToDouble(Console.ReadLine());
                total+=Convert.ToInt32(tipm.tip);
                Console.WriteLine("Thank you very much!");
            }
            else 
                {Console.WriteLine("Okay, sure");}
            
            payment.pay_bill(total);
            
            Console.WriteLine("Have a nice day, Sir/Ma'am!");
    }
}