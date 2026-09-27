namespace looplab_oop_competition;

public class Pharmacist : User {
    private String liscense;

    public Pharmacist(
        int id,
        String name,
        String license
    ) : base(id, name)
    {
        this.liscense = license;
    }

    public override void displayInfo()
    {
        Console.WriteLine($"Id:{this.id} \n Name:{this.name} \n License : {this.liscense}");
    }
}