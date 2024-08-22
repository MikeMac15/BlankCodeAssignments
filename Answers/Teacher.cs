public class Teacher
{
    public string FirstName;
    public string LastName;
    public string Subject;
    public int RoomNumber;
    public int GradeLevel;
    public bool Substitute;
    public string PhoneNumber;
    public string Email;
    private string __Address;

    public Teacher(string firstName, string lastName, string subject, int roomNumber, int gradeLevel, bool substitute, string phoneNumber, string email, string address)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Subject = subject;
        this.RoomNumber = roomNumber;
        this.GradeLevel = gradeLevel;
        this.Substitute = substitute;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
        this.__Address = address;
    }

    public string GetAddress(bool? autho)
    {
        if (autho != null && autho == true)
        {
            return this.__Address;
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
                return this.__Address;
            }
            else
            {
                return "You are not authorized to view this information";
            }
        }

    }
    public string DisplayTeacherInfo()
    {
        if (this.Substitute)
        {
            return $"{this.FirstName} {this.LastName} is a substitute {this.Subject} teacher in room {this.RoomNumber}.";
        }
        return $"{this.FirstName} {this.LastName} teaches {this.Subject} in room {this.RoomNumber}.";
    }

    public string DisplayContactInfo()
    {
        return $"Contact {this.FirstName} {this.LastName} at {this.PhoneNumber} or {this.Email}.";
    }
}