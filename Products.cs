namespace Containers;

public class Products
{
    public bool Hazardous;
    public double weight;
    public String name;
    public double temperature;

    public Products(bool hazardous, double weight, String name, double temperature)
    {
        this.Hazardous = hazardous;
        this.weight = weight;
        this.name = name;
        this.temperature = temperature;
    }


}