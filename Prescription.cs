namespace looplab_oop_competition;

public class Prescription {
    private PrescriptionStatus status;
    private int id;

    public Prescription(
        int id,
        PrescriptionStatus status
    )
    {
        this.id = id;
        this.status = status;
    }

    public bool isValid()
    {
        return this.status == PrescriptionStatus.VALID;
    }
}