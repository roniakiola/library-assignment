namespace src.Users
{
  public abstract class Person
  {
    public string Name { get; set; }
    public string ID { get; private set; }

    public Person(string name)
    {
      Name = name;
      ID = Guid.NewGuid().ToString();
    }
  }
}