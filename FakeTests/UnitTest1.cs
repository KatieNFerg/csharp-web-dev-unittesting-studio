using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace FakeTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        //Arrange
string expected = "kg";
        //Act
string actual = Utils.getinitials


        //Assert
        Assert.AreEqual(expected, actual);//third spot for decimal
    }
}