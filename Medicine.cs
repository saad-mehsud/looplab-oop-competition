namespace looplab_oop_competition;

public class Medicine {
    private Supplier supplier;
    private MedicineType type;
    private int quantity;
    public double price;
    private String name;
    private int id;
    private bool prescriptionRequired;

    public Medicine(
        int id,
        String name,
        double price,
        int quantity,
        MedicineType type,
        bool prescriptionRequired,
        Supplier supplier
    )
    {
        this.id = id;
        this.name = name;
        this.price = price;
        this.quantity = quantity;
        this.type = type;
        this.prescriptionRequired = prescriptionRequired;
        this.supplier = supplier;
    }

    public void displayInfo()
    {
        Console.WriteLine($" Id : {this.id} \n Name : {this.name} \n Price:{this.quantity} \n Medicine Type : { this.type.ToString()} \n Prescription Required:{this.prescriptionRequired} \n Supplier : {this.supplier.getName()} ");
    }

    public Medicine shallowCopy()
    {
        return (Medicine)this.MemberwiseClone();
    }

    public Medicine deepCopy()
    {
        return new Medicine(
            this.id,
            this.name,
            this.price,
            this.quantity,
            this.type,
            this.prescriptionRequired,
            this.supplier
        );
    }

    public int compareTo(Medicine other)
    {
        return this.id.CompareTo(other.id);
    }

    public Supplier getSupplier()
    {
        return this.supplier;
    }
}