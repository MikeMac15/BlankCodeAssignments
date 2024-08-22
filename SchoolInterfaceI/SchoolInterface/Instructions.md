~ School Interface I ~
* Create a student class that holds basic student information that can be used by front desk staff.
* Student class must hold FirstName, LastName, Parent1Name, Parent2Name(can be null), PhoneNumber(string), Email, Address(private), HomeRoom(int), Grade(int), LockerNumber(int)
-- Must have Contstructor, use exact names above ^ in exact order in constructor.
* Must have 4 Methods - GetAddress(), DisplayStudentInfo(), DisplayParentInfo(), DisplayLockerInfo()
-- use the returns provided bellow.

* Start by creating a .cs file with name of class you're creating & you wont need to work outside of it.. yet

Student class

-- use this --
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
DisplayStudentInfo()
    return $"{FirstName} {LastName} is in grade {Grade} and is in homeroom {HomeRoom}.";

DisplayParentInfo()
    if parent2name is null
        return $"{Parent1Name} can be reached at {PhoneNumber} or {Email}.";
    else
    return $"{Parent1Name} and {Parent2Name} can be reached at {PhoneNumber} or {Email}.";
DisplayLockerInfo()
    return $"{FirstName} {LastName} has locker number {LockerNumber}.";

