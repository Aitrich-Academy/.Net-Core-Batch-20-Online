using StudentApp;

class Program
{
	static void Main(string[] args)
	{
		IStudentCollection studentCollection = new StudentCollection();

		bool exit = false;
		while (!exit)
		{
			Console.WriteLine("\nStudent Management System");
			Console.WriteLine("1. Add Student");
			
			Console.WriteLine("2. View Student");
			Console.WriteLine("3. List All Students");
			Console.WriteLine("4. Exit");
			Console.Write("Enter your choice: ");

			int choice;
			if (int.TryParse(Console.ReadLine(), out choice))
			{
				switch (choice)
				{
					case 1:
						Console.Write("Enter Student ID: ");
						string id = Console.ReadLine();
						Console.Write("Enter Student Name: ");
						string name = Console.ReadLine();
						Console.Write("Enter Student Age: ");
						int age;
						if (int.TryParse(Console.ReadLine(), out age))
						{
							Console.Write("Enter Student GPA: ");
							double gpa;
							if (double.TryParse(Console.ReadLine(), out gpa))
							{
								Student newStudent = new Student { StudentID = id, Name = name, Age = age, GPA = gpa };
								studentCollection.AddStudent(newStudent);
								Console.WriteLine("Student added successfully.");
							}
							else
							{
								Console.WriteLine("Invalid GPA.");
							}
						}
						else
						{
							Console.WriteLine("Invalid Age.");
						}
						break;

					case 2:
						Console.Write("Enter Student ID to view: ");
						string idToView = Console.ReadLine();
						Student student = studentCollection.GetStudent(idToView);
						if (student != null)
						{
							Console.WriteLine($"ID: {student.StudentID}, Name: {student.Name}, Age: {student.Age}, GPA: {student.GPA}");
						}
						else
						{
							Console.WriteLine("Student not found.");
						}
						break;
					case 3:
						studentCollection.ListAllStudents();
						break;
					case 4:
						exit = true;
						Console.WriteLine("Exiting...");
						break;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
			else
			{
				Console.WriteLine("Invalid choice. Please enter a number.");
			}
		}
	}
}