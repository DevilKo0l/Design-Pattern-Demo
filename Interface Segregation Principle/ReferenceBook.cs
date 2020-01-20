using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public class ReferenceBook : IBook
    {
        public string Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int pages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LibraryId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
