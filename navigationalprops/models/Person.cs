using System;
using System.Collections.Generic;
using System.Text;

namespace navigationalprops.models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Adress> Adresses { get; set; } = new List<Adress>();
        public List<Email> Emails { get; set; } = new List<Email>();
    }
}
