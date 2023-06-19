namespace src.Users
{
  public abstract class Person
  {
    public string Name { get; set; }
    public int ID { get; private set; }

    public Person(string name, int id)
    {
      Name = name;
      ID = id;
    }
  }
}