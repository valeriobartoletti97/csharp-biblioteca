using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {
        public string Code { get; private set; }
        public string Title { get;  set; }
        public int Year { get; set; }   
        public string Theme { get; set; }
        public int Section { get; set; }
        public string Author { get; set; }
    }
}
