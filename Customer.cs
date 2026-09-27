namespace looplab_oop_competition;

public class Customer  : User
{
    public Customer(int id, String name):base(id, name)
    {
    }

    public override void displayInfo()
    {
        Console.WriteLine($"ID:{this.id} \n Name:{this.name}");
    }

    public Sale purchaseMedicine(
            Medicine medicine,
            int quantity,
            Pharmacist pharmacist
        )
        //throws InvalidMedicineException;
    {
        Sale sale = new Sale();
        sale.getTotalAmount(medicine.price, quantity);
        return sale;
    }

    public Sale purchaseMedicine(
        Medicine medicine,
        int quantity,
        Pharmacist pharmacist,
        Prescription prescription
    )
    {
        try
        {
            if (prescription.isValid())
            {
                Sale sale = new Sale();
                sale.getTotalAmount(medicine.price, quantity);
                return sale;
            }
            else
            {
                throw new InvalidMedicineException("Prescription is not valid");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return null;
    }
    //throws InvalidMedicineException;
    
}