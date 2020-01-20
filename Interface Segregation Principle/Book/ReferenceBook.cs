using System;

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