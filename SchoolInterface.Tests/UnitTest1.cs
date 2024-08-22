namespace SchoolInterface.Tests;

[TestClass]
public class UnitTest1
{
    Student student1 = new Student("John", "Doe", "Jane Doe", null, "555-555-5555", "blah@gmail.com", "1234 Elm St", 101, 9, 1);
    Student student2 = new Student("Jane", "Doe", "John Doe", "Other Doe", "555-555-5555", "ouei@gmail.com", "1234 Elm St", 101, 9, 2);
    
    [TestMethod]
    public void TestMethod1_Student()
    {
        Assert.AreEqual("John", student1.FirstName);
        Assert.AreEqual("Doe", student1.LastName);
        Assert.AreEqual("Jane", student2.FirstName);
        Assert.AreEqual("Doe", student2.LastName);
    }
    [TestMethod]
    public void TestMethod3_ParentNames()
    {
        Assert.AreEqual("Jane Doe", student1.Parent1Name);
        Assert.AreEqual("John Doe", student2.Parent1Name);
        Assert.AreEqual(null, student1.Parent2Name);
        Assert.AreEqual("Other Doe", student2.Parent2Name);
    }
    [TestMethod]
    public void TestMethod4_PhoneNumbers()
    {
        Assert.AreEqual("555-555-5555", student1.PhoneNumber);
        Assert.AreEqual("555-555-5555", student2.PhoneNumber);
        Assert.AreEqual(student1.PhoneNumber, student2.PhoneNumber);
    }
    [TestMethod]
    public void TestMethod5_DisplayMethods()
    {
        Assert.AreEqual("Jane Doe is in grade 9 and is in homeroom 101.", student2.DisplayStudentInfo());
        Assert.AreEqual("John Doe is in grade 9 and is in homeroom 101.", student1.DisplayStudentInfo());
        Assert.AreEqual("Jane Doe can be reached at 555-555-5555 or blah@gmail.com.", student1.DisplayParentInfo());
        Assert.AreEqual("John Doe and Other Doe can be reached at 555-555-5555 or ouei@gmail.com.", student2.DisplayParentInfo());
        Assert.AreEqual("John Doe has locker number 1.", student1.DisplayLockerInfo());
        Assert.AreEqual("Jane Doe has locker number 2.", student2.DisplayLockerInfo());
    }
    [TestMethod]
    public void TestMethod6_GetAddress()
    {
        Assert.AreEqual("1234 Elm St", student1.GetAddress(true));
        Assert.AreEqual("You are not authorized to view this information", student2.GetAddress(false));
    }
        
}