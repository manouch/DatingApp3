namespace API.Entities
{
  public class Connection
  {
    public Connection()
    {
    }

    public Connection(string connectionId, string usersname)
    {
      ConnectionId = connectionId;
      Usersname = usersname;
    }

    public string ConnectionId { get; set; }
    public string Usersname { get; set; }
  }
}