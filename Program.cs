using System.Net.Security;
using Containers;
using Microsoft.VisualBasic;


public class Program
{
    
    

    public static void Main(string[] args)
    {
        FreezerContainer freezerContainer = new FreezerContainer(300.50,150.0,5.3,30.0, 10.0);
        GasContainer gasContainer = new GasContainer(400.80,200.0,6.1,50.0, 30.0);
        LiquidContainer liquidContainer = new LiquidContainer(250.25,130.0,4.3,20.5);
        
        Console.WriteLine(freezerContainer.toString());
        Console.WriteLine(gasContainer.toString());
        Console.WriteLine(liquidContainer.toString());

        Products a = new Products(true, 40.0, "Mleko", 11.0);
        Products b = new Products(false, 20.0, "Jabłka", 12.0);
        
        freezerContainer.addProduct(a);
        //freezerContainer.fill(300);
        freezerContainer.printWeight();
        //freezerContainer.fill(60);
        freezerContainer.printWeight();
        freezerContainer.addProduct(b);
        freezerContainer.remove();
        freezerContainer.printWeight();
        
        gasContainer.addProduct(a);
        gasContainer.printWeight();
        //gasContainer.fill(250);
        gasContainer.printWeight();
        
        liquidContainer.addProduct(a);
        liquidContainer.printWeight();
        //liquidContainer.fill(190);
        liquidContainer.printWeight();

        List<Container> containers = new List<Container>();
        containers.Add(freezerContainer);
        containers.Add(gasContainer);
        
        Ship first = new Ship(30.0, 2, 500.0);
        Ship second = new Ship(30.0, 4, 1500.0);
        
        first.loadContainer(liquidContainer);
        Console.WriteLine(first.toString());
        second.loadContainers(containers);
        Console.WriteLine(second.toString());
        second.removeContainer(freezerContainer);
        second.transferContainer(gasContainer.series, first);
        Console.WriteLine(second.toString());
        first.loadContainer(freezerContainer);
        



    }
    
    
}







