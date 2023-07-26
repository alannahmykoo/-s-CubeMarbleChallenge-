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
        [TestMethod]
        public void TestPalindrome()
        {
            String trueString = " Bob O'Bob";
            String falseString = "Bob O'Bobb";
            bool isPalindrome = StringHelper.IsPalindrome(trueString);
            bool notPalindrome = StringHelper.IsPalindrome(falseString);

            Assert.IsTrue(isPalindrome);
            Assert.IsFalse(notPalindrome);
        }
        [TestMethod]
        public void TestSortAndFilter()
        {
            List<Marble> marbleList = new List<Marble>()
            {
                new Marble() {ID= 1, Color = "blue", Weight = 0.5, Name = "Bob"},
                new Marble() {ID = 2, Color = "red", Weight = 0.25, Name = "John Smith"},
                new Marble() {ID = 3, Color = "violet", Weight = 0.5, Name = "Bob O'Bob"},
                new Marble() {ID = 4, Color = "indigo", Weight = 0.75, Name = "Bob Dad-Bob"},
                new Marble() {ID = 5, Color = "yellow", Weight = 0.5, Name = "John"},
                new Marble() {ID = 6, Color = "orange", Weight = 0.25, Name = "Bob"},
                new Marble() {ID = 7, Color = "blue", Weight = 0.5, Name = "Smith"},
                new Marble() {ID = 8, Color = "blue", Weight = 0.25, Name = "Bob"},
                new Marble() {ID = 9, Color = "green", Weight = 0.75, Name = "Bobb Ob"},
                new Marble() {ID = 10, Color = "blue", Weight = 0.5, Name = "Bob"}
            };
            List<Marble> sortedMarbles = MarbleChallenge.SortAndFilter(marbleList);

            // 9, 1, 10, 4 , 3

            Assert.AreEqual(5, sortedMarbles.Count);
            Assert.AreEqual(9, sortedMarbles[0].ID);
            Assert.AreEqual(1, sortedMarbles[1].ID);
            Assert.AreEqual(10, sortedMarbles[2].ID);
            Assert.AreEqual(4, sortedMarbles[3].ID);
            Assert.AreEqual(3, sortedMarbles[4].ID);
        }  
    }
    
}


