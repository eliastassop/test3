using System;
using System.Collections.Generic;
using System.Text;

namespace navigationalprops.models
{
    public class Adress
    {
        public int Id{ get; set; }
        public string  StreetAddress{ get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
}
