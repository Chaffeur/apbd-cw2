namespace Containers;

public class FreezerContainer : Container
{
    
    double temperature;
    private string productName = "";

    public FreezerContainer(double maxWeight, double cWeight, double height, double depth, double temperature)
        : base(maxWeight: maxWeight, cWeight: cWeight, height: height, depth:depth)
    {
        this.series = "KON-F-" + num;
        this.temperature = temperature;
        
    }


    public string toString()
    {
        return base.toString() + "\n Temperature: " + this.temperature;
    }

    public override void fill(double weight)
    {
        base.fill(weight);
    }

    public override void addProduct(Products product)
    {
        if (temperature > product.temperature)
        {
            Console.WriteLine("Kontener utrzymuje zbyt wysoką temperature");
        }
        else
        {
            if (this.productName.Equals(product.name) || this.productName.Equals(""))
            {
                this.productName = product.name;
                base.addProduct(product);
            }
            else
            {
                Console.WriteLine("Nie można załadować kontenera innym typem produktu");
            }
            
        }
        
        
            
        
    }
}