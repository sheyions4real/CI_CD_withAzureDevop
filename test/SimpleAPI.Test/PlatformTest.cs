using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.Test;

public class PlatformTest
{
  PlatformController controller = new PlatformController();

  [Fact]
  public void TestGetPlatformCount()
  {
       
       var recordCount = controller.GetPlatforms();
        Assert.True(recordCount.Count <0 ,"Result count should be greater than 0");
  }
    





    [Fact]
    public void Test1()
    {

    }
}