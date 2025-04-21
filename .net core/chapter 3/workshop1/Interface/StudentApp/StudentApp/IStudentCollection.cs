  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
	public interface IStudentCollection
	{
		public void AddStudent(Student student);
		
		Student GetStudent(string studentID);
		void ListAllStudents();
	}
}
