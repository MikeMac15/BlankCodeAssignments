public class Student
{
    public string FirstName;
    public string LastName;
    public string Parent1Name;
    public string? Parent2Name;
    public string PhoneNumber;
    public string Email;
    private string Address;
    public int HomeRoom;
    public int Grade;
    public int LockerNumber;


    public Student(string firstName, string lastName, string parent1Name, string? parent2Name, string phoneNumber, string email, string address, int homeRoom, int grade, int lockerNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Parent1Name = parent1Name;
        Parent2Name = parent2Name;
        PhoneNumber = phoneNumber;
        Email = email;
        Address = address;
        HomeRoom = homeRoom;
        Grade = grade;
        LockerNumber = lockerNumber;
    }

    public string GetAddress(bool? autho)
    {
        if (autho != null && autho == true)
        {
            return Address;
        }
        else if (autho != null && autho == false)
        {
            return "You are not authorized to view this information";
        }
        else
        {

            string? auth = Console.ReadLine();
            if (auth == "admin")
            {
                return Address;
            }
            else
            {
                return "You are not authorized to view this information";
            }
        }

    }
    public string DisplayStudentInfo()
    {
        return $"{FirstName} {LastName} is in grade {Grade} and is in homeroom {HomeRoom}.";
    }

    public string DisplayParentInfo()
    {
        if (Parent2Name == null)
        {
            return $"{Parent1Name} can be reached at {PhoneNumber} or {Email}.";
        }
        return $"{Parent1Name} and {Parent2Name} can be reached at {PhoneNumber} or {Email}.";
    }
    public string DisplayLockerInfo()
    {
        return $"{FirstName} {LastName} has locker number {LockerNumber}.";
    }

}