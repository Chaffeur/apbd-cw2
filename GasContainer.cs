namespace Containers;

public class GasContainer : Container, IHazardNotifier
{
    private double pressure;
    
    public GasContainer(double maxWeight, double cWeight, double height, double depth, double pressure)
        : base(maxWeight: maxWeight, cWeight: cWeight, height: height, depth:depth)
    {
        this.series = "KON-G-" + num;
        this.pressure = pressure;
    }
    
    
    public string toString()
    {
        return base.toString() + "\n Pressure: " + this.pressure;
    }

    public override void fill(double weight)
    {
        if (weight + this.weight > this.maxWeight)
        {
            base.fill(weight);
        }
        else
        {
            notify();
        }
    }

    public override void remove()
    {
        
        double fiveprcnt = this.weight * (95 / 100);
        this.weight -= fiveprcnt;
        this.products.Clear();

    }

    public void notify()
    {
        throw new OverfillException("Weight is greater than max weight");
    }
}