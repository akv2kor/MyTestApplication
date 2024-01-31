namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            String firstName = "Arun";
            String lastName = "Viswanath";
            String expected = "Arun Viswanath";
            String actual;
            //Act  
            actual = $"{firstName} {lastName}";
            //Assert  
            Assert.AreEqual(expected, actual);
        }
    }
}