using System;
using System.Collections.Generic;
using System.Text;

namespace MultilingualDemo.Models
{
    public class Language
    {
        public Language(string name, string ci)
        {
            Name = name;
            CI = ci;
        }

        public string Name { get; set; }
        public string CI { get; set; }
    }
}
