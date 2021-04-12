using System;
using System.Collections.Generic;
using System.Text;

namespace c_sqlite
{
    public class PersonModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { SecondName }";
            }
        }
    }
}
