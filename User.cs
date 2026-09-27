namespace looplab_oop_competition;
public abstract class User {
    public User(int id, String name)
    {
        this.id = id;
        this.name = name;
    }
    protected int id;
    protected String name;


    public abstract void displayInfo();
}