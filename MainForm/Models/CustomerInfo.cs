using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;


namespace UI_Example.Models
{
    enum CustomerSex { MALE, FEMALE}

    class CustomerInfo
    {
        public int Id { get;}
        public String Name { get; }
        public DateTime DOB { get; }
        public CustomerSex Sex { get; }
        public double Balance { get; set; }

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

        public CustomerInfo(DataRow row)
        {
            Id = (int)row.Field<Int64>("id");
            Name = row.Field<String>("name");
            DOB = DateTime.Parse(row.Field<String>("dob"), CultureInfo.CreateSpecificCulture("en-US"));
            Sex = (CustomerSex)Enum.Parse(typeof(CustomerSex), row.Field<String>("sex"));
            Balance = row.Field<double>("balance");
        }

    }
}
