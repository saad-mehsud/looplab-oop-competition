namespace looplab_oop_competition;

public class InvalidMedicineException : Exception {

    public InvalidMedicineException(
        String message
    )
    {
        Console.WriteLine(message);
    }
}