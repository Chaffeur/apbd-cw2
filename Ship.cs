namespace Containers;

public class Ship
{
    
    public List<Container> containers = new List<Container>();
    public double speed;
    public int containerLimit;
    public double maxWeight;

    public Ship(double speed, int containerLimit, double maxWeight)
    {
        this.speed = speed;
        this.containerLimit = containerLimit;
        this.maxWeight = maxWeight;
    }

    public void loadContainer(Container container)
    {
        
        int currentContainerCount = containerLimit + 1;
        
        if (container.weight > maxWeight || currentContainerCount > containerLimit)
        {
            new OverfillException("Too many/heavy container");
        }
        else
        {
            maxWeight = container.weight;
            containers.Add(container);
        }
        
    }

    public void loadContainers(List<Container> containers)
    {

        int currentContainerCount = containerLimit;
        
        foreach (Container container in containers)
        {
            currentContainerCount++;
            if (container.weight > maxWeight || currentContainerCount > containerLimit)
            {
                new OverfillException("Too many/heavy containers");
            }
            else
            {
                maxWeight = container.weight;
                containers.Add(container);
            }
            
            
        }
    }

    public void removeContainer(Container container)
    {
        containers.Remove(container);
    }

    public void swapContainers(String series, Container newContainer)
    {
        foreach (Container container in containers)
        {
            if (container.series.Equals(series))
            {
                containers.Remove(container);
            }
            else
            {
                throw new Exception("Brak kontenera o tym numerze seryjnym");
            }
            
            containers.Add(newContainer);
        }
    }

    public void transferContainer(String series, Ship newShip)
    {
        foreach (Container container in containers)
        {
            if (container.series.Equals(series))
            {
                newShip.containers.Add(container);
                containers.Remove(container);
            }
            else
            {
                throw new Exception("Brak kontenera o tym numerze seryjnym");
            }
            
        }
    }

    public String toString()
    {
        string result = string.Join(", ", this.containers);
        return "Max weight: " + this.maxWeight + "\n Speed: " + this.speed + "\n Containers: " + result;
    }


}