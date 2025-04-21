using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Excercise
{
	public class User
	{
		protected string username;
		protected string password;

		public User(string username, string password)
		{
			this.username = username;
			this.password = password;
		}

		public bool Authenticate(string enteredUsername, string enteredPassword)
		{
			return (username == enteredUsername && password == enteredPassword);
		}
	}
}
