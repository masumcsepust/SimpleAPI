using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    PersonalController controller = new PersonalController();

    [Fact] 
    public void GetName() {
        var getName = controller.GetName();
        Assert.Equal("Masum", getName.Value);
    }
    [Fact]
    public void Test1()
    {

    }
}