namespace MarbleTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMarble()
        {
            Marble marble = new Marble();
            marble.ID = 1;
            marble.Name = "Bob";
            marble.Color = "blue";
            marble.Weight = 0.5;

            Assert.AreEqual(1, marble.ID);
            Assert.AreEqual(0.5, marble.Weight);
            Assert.AreEqual("Bob", marble.Name);
            Assert.AreEqual("blue", marble.Color);
        }
        [TestMethod]
        public void TestClean()
        {
            String testString = "Bob o'Bob";
            String cleanString = StringHelper.CleanString(testString);

            Assert.AreEqual("bobobob", cleanString);
        }

        [TestMethod]
        public void TestReverse()

        {
            String testString = "reversethisstring";
            String reverseString = StringHelper.ReverseString(testString);

            Assert.AreEqual("gnirtssihtesrever", reverseString);
        }
    }
    
}

