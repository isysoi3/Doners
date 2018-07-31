using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UI_Example.Models
{
    public class UserInfo
    {
        public String Name { get; }

        public UserInfo(DataRow row)
        {
            Name = row.Field<String>("name");
        }
    }
}
