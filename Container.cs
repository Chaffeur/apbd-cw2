namespace Containers;

public class Container
{
    public double weight = 0;
    protected double height;
    protected double cWeight;
    protected double depth;
    public string series;
    protected double maxWeight;
    protected List<Products> products = new List<Products>();
    protected static int num = 0;
    
    public Container(double maxWeight, double cWeight, double height, double depth)
    {
        this.maxWeight = maxWeight;
        this.cWeight = cWeight;
        this.height = height;
        this.depth = depth;
        num = num + 1;

    }

    public void printWeight()
    {
        Console.WriteLine(this.weight);
    }
    
    public virtual void remove()
    {
        foreach (Products p in products)
        {
            weight -= p.weight;
        }
        products.Clear();
        
    }

    public virtual void fill(double weight)
    {

        if (weight > maxWeight) throw new OverfillException("Weight is greater than max weight");
        else
        {
            this.weight += weight;
        }


    }
    
    public virtual void addProduct(Products product){
        if (weight > maxWeight) throw new OverfillException("Weight is greater than max weight");
        else
        {
            products.Add(product);
            this.weight += product.weight;
        }
        
        
    }

    public void addProducts(List<Products> products)
    {
        List<Products> newProducts = new List<Products>();
        foreach (Products product in products)
        {
            newProducts.Add(product);
            this.weight = this.weight + product.weight;
        }
    }

    public String toString()
    {
        string result = string.Join(", ", this.products);
        return "Series: " + this.series + "\n Weight: " + this.weight + "\n Products: " + result;
    }
    
}