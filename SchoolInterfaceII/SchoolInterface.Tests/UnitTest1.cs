using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SchoolInterface.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private void TryAssert(Action assertAction, string description, List<string> failures)
        {
            try
            {
                assertAction();
                
            }
            catch (AssertFailedException ex)
            {
                failures.Add($"Failed: {description} - {ex.Message}");
                Console.Error.WriteLine($"Failed: {description} - {ex.Message}");
                
            }
        }

        private bool HasMethod(Type type, string methodName)
{
    return type?.GetMethod(methodName) != null;
}

        [TestMethod]
        public void TestMethodBase_StudentClass()
        {
            Student student1 = new Student("John", "Doe", "Jane Doe", null, "555-555-5555", "blah@gmail.com", "1234 Elm St", 101, 9, 1);
            Student student2 = new Student("Jane", "Doe", "John Doe", "Other Doe", "555-555-5555", "ouei@gmail.com", "1234 Elm St", 101, 9, 2);

            List<string> failures = new List<string>();

            TryAssert(() => Assert.AreEqual("John", student1.FirstName), "FirstName check for student1", failures);
            TryAssert(() => Assert.AreEqual("Doe", student1.LastName), "LastName check for student1", failures);
            TryAssert(() => Assert.AreEqual("Jane", student2.FirstName), "FirstName check for student2", failures);
            TryAssert(() => Assert.AreEqual("Doe", student2.LastName), "LastName check for student2", failures);
            TryAssert(() => Assert.AreEqual("Jane Doe", student1.Parent1Name), "Parent1Name check for student1", failures);
            TryAssert(() => Assert.AreEqual("John Doe", student2.Parent1Name), "Parent1Name check for student2", failures);
            TryAssert(() => Assert.AreEqual(null, student1.Parent2Name), "Parent2Name check for student1", failures);
            TryAssert(() => Assert.AreEqual("Other Doe", student2.Parent2Name), "Parent2Name check for student2", failures);
            TryAssert(() => Assert.AreEqual("555-555-5555", student1.PhoneNumber), "PhoneNumber check for student1", failures);
            TryAssert(() => Assert.AreEqual("555-555-5555", student2.PhoneNumber), "PhoneNumber check for student2", failures);
            TryAssert(() => Assert.AreEqual(student1.PhoneNumber, student2.PhoneNumber), "PhoneNumber equality check", failures);
            TryAssert(() => Assert.AreEqual("Jane Doe is in grade 9 and is in homeroom 101.", student2.DisplayStudentInfo()), "DisplayStudentInfo check for student2", failures);
            TryAssert(() => Assert.AreEqual("John Doe is in grade 9 and is in homeroom 101.", student1.DisplayStudentInfo()), "DisplayStudentInfo check for student1", failures);
            TryAssert(() => Assert.AreEqual("Jane Doe can be reached at 555-555-5555 or blah@gmail.com.", student1.DisplayParentInfo()), "DisplayParentInfo check for student1", failures);
            TryAssert(() => Assert.AreEqual("John Doe and Other Doe can be reached at 555-555-5555 or ouei@gmail.com.", student2.DisplayParentInfo()), "DisplayParentInfo check for student2", failures);
            TryAssert(() => Assert.AreEqual("John Doe has locker number 1.", student1.DisplayLockerInfo()), "DisplayLockerInfo check for student1", failures);
            TryAssert(() => Assert.AreEqual("Jane Doe has locker number 2.", student2.DisplayLockerInfo()), "DisplayLockerInfo check for student2", failures);
            TryAssert(() => Assert.AreEqual("1234 Elm St", student1.GetAddress(true)), "GetAddress check for student1 with authorization", failures);
            TryAssert(() => Assert.AreEqual("You are not authorized to view this information", student2.GetAddress(false)), "GetAddress check for student2 without authorization", failures);

            if (failures.Count > 0)
            {
                Assert.Fail($"---------------------------------------------------- Failed {failures.Count} test ----------------------------------------------------");
            }
        }

        [TestMethod]
public void TestClassHasMethod()
{
    Type studentType = typeof(Student);
    Type teacherType = typeof(Teacher);
    List<string> failures = new List<string>();
    TryAssert(() => Assert.IsTrue(HasMethod(teacherType, "GetAddress"), "Teacher class should have GetAddress() method"), "FirstName check for student1", failures);
    TryAssert(() => Assert.IsTrue(HasMethod(teacherType, "DisplayTeacherInfo"), "Teacher class should have DisplayTeacherInfo() method"), "FirstName check for student1", failures);
    TryAssert(() => Assert.IsTrue(HasMethod(teacherType, "DisplayContactInfo"), "Teacher class should have DisplayContactInfo() method"), "FirstName check for student1", failures);
    // Add more method checks as needed
}

        [TestMethod]
        public void TestMethod1_Teacher()
        {
        
                Teacher teacher1 = new Teacher("John", "Doe", "Math", 101, 9, false, "555-555-5555", "1@gmail.com", "1234 Elm St");
                Teacher teacher2 = new Teacher("Jane", "Doe", "Science", 102, 9, false, "555-555-5555", "2@gmail.com", "1234 Elm St");

                 List<string> failures = new List<string>();

                TryAssert(() => Assert.AreEqual("John", teacher1.FirstName), "FirstName check for student1", failures);
                TryAssert(() => Assert.AreEqual("Doe", teacher1.LastName), "FirstName check for student1", failures);
                TryAssert(() => Assert.AreEqual("Jane", teacher2.FirstName), "FirstName check for student1", failures);
                TryAssert(() => Assert.AreEqual("Doe", teacher2.LastName), "FirstName check for student1", failures);
                TryAssert(() => Assert.AreEqual("555-555-5555", teacher1.PhoneNumber), "FirstName check for student1", failures);
                TryAssert(() => Assert.AreEqual("555-555-5555", teacher2.PhoneNumber), "FirstName check for student1", failures);
                TryAssert(() => Assert.AreEqual(teacher1.PhoneNumber, teacher2.PhoneNumber), "FirstName check for student1", failures);
        
        if (failures.Count > 0)
            {
                Assert.Fail($"---------------------------------------------------- Failed {failures.Count} test ----------------------------------------------------");
            }
        }

        [TestMethod]
        public void TestMethod2_DisplayTeacherInfo()
        {
            
                Teacher teacher1 = new Teacher("John", "Doe", "Math", 101, 9, false, "555-555-5555", "1@gmail.com", "1234 Elm St");
                Teacher teacher2 = new Teacher("Jane", "Doe", "Science", 102, 9, false, "555-555-5555", "2@gmail.com", "1234 Elm St");
List<string> failures = new List<string>();
                TryAssert(() => Assert.AreEqual("John Doe teaches Math in room 101.", teacher1.DisplayTeacherInfo()), "teacher1 info", failures);
                TryAssert(() => Assert.AreEqual("Jane Doe teaches Science in room 102.", teacher2.DisplayTeacherInfo()), "teacher2 info", failures);
            
            if (failures.Count > 0)
            {
                Assert.Fail($"---------------------------------------------------- Failed {failures.Count} test ----------------------------------------------------");
            }
        }

        [TestMethod]
        public void TestMethod3_DisplayTeacherAddress()
        {
            
                Teacher teacher1 = new Teacher("John", "Doe", "Math", 101, 9, false, "555-555-5555", "1@gmail.com", "1234 Elm St");
                Teacher teacher2 = new Teacher("Jane", "Doe", "Science", 102, 9, false, "555-555-5555", "2@gmail.com", "1234 Elm St");
List<string> failures = new List<string>();
                TryAssert(() => Assert.AreEqual("1234 Elm St", teacher1.GetAddress(true)), "getaddress(true)", failures);
                TryAssert(() => Assert.AreEqual("You are not authorized to view this information", teacher2.GetAddress(false)), "no-auth getaddress()", failures);
            
            if (failures.Count > 0)
            {
                Assert.Fail($"---------------------------------------------------- Failed {failures.Count} test ----------------------------------------------------");
            }
        }

        [TestMethod]
        public void TestMethod4_SubstituteTeacher()
        {
            List<string> failures = new List<string>();
                Teacher teacher3 = new Teacher("Jim", "Doe", "English", 101, 9, true, "555-555-5555", "3@gmail.com", "1 Elm St");
                Assert.AreEqual("Jim Doe is a substitute English teacher in room 101.", teacher3.DisplayTeacherInfo());

                if (failures.Count > 0)
            {
                Assert.Fail($"---------------------------------------------------- Failed {failures.Count} test ----------------------------------------------------");
            }
            
        }


            
        }


    }
