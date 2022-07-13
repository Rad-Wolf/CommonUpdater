namespace Common
{
  public class BasicSingleton<T> where T : class, new()
  {
    private static T SingleObject;
    private static object Locker = new object( );

    public static T Instant {
      get {
        lock ( Locker )
        {
          if ( SingleObject is null )
            SingleObject = new T( );
          return SingleObject;
        }
      }
    }
  }
}