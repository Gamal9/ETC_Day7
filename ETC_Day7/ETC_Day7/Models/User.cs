using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETC_Day7.Models
{
    public class User
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
