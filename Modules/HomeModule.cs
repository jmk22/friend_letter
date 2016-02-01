namespace FriendLetter
{
  using Nancy;

  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/hello"] = _ => "Hello friend!";
      Get["/goodbye"] = _ => "Goodbye friend!";
    }
  }
}
