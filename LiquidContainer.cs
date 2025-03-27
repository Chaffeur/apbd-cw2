namespace Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    
    bool hazardous = false;
    


    public LiquidContainer(double maxWeight, double cWeight, double height, double depth)
        : base(maxWeight: maxWeight, cWeight: cWeight, height: height, depth:depth)
    {
        this.series = "KON-L-" + num;
    }


    public void notify()
    {
        Console.WriteLine("WARNING: " + this.series);
    }

    public override void fill(double weight)
    {
        if (hazardous)
        {
            if (this.maxWeight / 2 < weight)
            {
                throw new OverfillException("Weight is greater than max weight");
            }
            else
                this.weight += weight;
                
        }
        else
        {
            if (this.maxWeight * (0.9) > weight)
            {
                this.weight += weight;
            }
            else
                throw new OverfillException("Weight is greater than max weight");
            
        }
    }

    public override void addProduct(Products product)
    {
        if (product.Hazardous)
        {
            this.hazardous = true;
            notify();
        }

        if (this.maxWeight * 0.9 > this.weight)
        {
            this.weight += product.weight;
        }
        else
            throw new OverfillException("Weight is greater than max weight");
    }


    public string toString()
    {
        return base.toString() + "\n Hazardous: " + this.hazardous;
    }
}