using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public class AudioBook : IBorrowableAudiobook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public int RuntimeInMinutes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime BorrowDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Borrower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CheckOutDurationInDays { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut(string borrower)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
