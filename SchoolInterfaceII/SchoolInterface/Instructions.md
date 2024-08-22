~ School Interface II ~

Description for Implementing the Teacher Class
Your task is to create a Teacher class in C# that represents a school teacher's information. The class should include both public and private fields, as well as methods to interact with the data. Below are the details you need to follow:

Fields:
Public Fields:

FirstName (string): The first name of the teacher.
LastName (string): The last name of the teacher.
Subject (string): The subject that the teacher teaches.
RoomNumber (int): The room number where the teacher holds classes.
GradeLevel (int): The grade level that the teacher teaches.
Substitute (bool): A flag indicating whether the teacher is a substitute.
PhoneNumber (string): The teacher's contact phone number.
Email (string): The teacher's contact email address.
Private Field:

__Address (string): The teacher's home address. This should be private and only accessible under certain conditions through a method.
Constructor:
Create a constructor that initializes all the fields, including the private __Address field. The constructor should accept parameters for each field and assign them accordingly.
Methods:
GetAddress(bool? autho):

This method returns the teacher's address if authorized.
If autho is true, return the address.
If autho is false, return "You are not authorized to view this information."
If autho is null, prompt the user to enter "admin". If they do, return the address; otherwise, return "You are not authorized to view this information."
DisplayTeacherInfo():

This method returns a string with the teacher's information.
If the teacher is a substitute (Substitute is true), the method should return a message indicating that the teacher is a substitute for the subject in the specified room.
Otherwise, it should return a message indicating that the teacher teaches the specified subject in the specified room.
DisplayContactInfo():

This method returns a string with the teacher's contact information, including their phone number and email address.
Example Usage:
After creating the Teacher class with the fields and methods described, you should be able to instantiate a Teacher object and use its methods to display teacher information and contact details, as well as retrieve the address if authorized.