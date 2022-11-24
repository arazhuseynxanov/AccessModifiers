using System;
namespace ClassLibrary
{
	public class Employee
	{
		private string _name;
		private string _surName;
		private int _salary;

		public Employee(string name,string surname,int salary)
		{
			Name = name;
            Surname = surname;
			Salary = salary;
		}

		public string Name
		{
			get { return _name; }
			set
			{
				value = value.Trim();
				if(value.Length>=2 && value.Length <= 15 && HasDigit(value) && HasUpper(value))
				{
					_name = value.Trim();
				}
				else
				{
					Console.WriteLine("Wrong Name");
				}
			}
		}

		public string Surname
		{
			get { return _surName; }
			set
			{
				value = value.Trim();
				if(value.Length >= 2 && value.Length <= 20 && HasDigit(value) && HasUpper(value))
				{
					_surName = value.Trim();
				}
				else
				{
					Console.WriteLine("Wrong Surname");
				}
			}
		}
		public int Salary
		{
			get { return _salary; }
			set
			{
				if (value >= 250 )
				{
					_salary = value;
				}
				else
				{
					Console.WriteLine("Salary 250-den Az olmamalidir");
				}				
			}
		}

        public bool HasDigit(string digit)
        {
            bool result;
            for (int i = 0; i < digit.Length; i++)
            {
                result = char.IsLetter(digit[i]);
                if (result == false)
                {
                    return false;
                }
            }
            return true;
        }
        public bool HasUpper(string upper)
        {
            bool result;
           
            result = char.IsUpper(upper[0]);
            if (result == true)
            {
				return true;
			}
            return false;
        }
    }
}

