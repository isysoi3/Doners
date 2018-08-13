using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Example.Models
{
    enum CustomerSex { MALE, FEMALE}

    class CustomerInfo
    {
        public int Id { get;}
        public String Name { get; }
        public DateTime DOB { get; }
        public CustomerSex Sex { get; }
        public float Balance { get; set; }

        public CustomerInfo(int id, String name, DateTime dob, CustomerSex sex)
        {
            Id = id;
            Name = name;
            DOB = dob;
            Sex = sex;
            Balance = 0;
        }

        public CustomerInfo(int id, String name, DateTime dob, CustomerSex sex, float balance) : this(id, name, dob, sex)
        {
            Balance = balance;
        }

    }
}
