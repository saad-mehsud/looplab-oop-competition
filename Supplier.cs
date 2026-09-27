namespace looplab_oop_competition;

public class Supplier  {
    String Address;
    String name;
    public Supplier(String name, String address) 
    {
        this.name = name;
        this.Address = address;
    }

    public String getName()
    {
        return name;
    }

    public String getAddress()
    {
        return Address;
    }
}