using System;

namespace Interface_Segregation_Principle
{
    public interface IBorrowable
    {
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }

        void CheckIn();

        void CheckOut(string borrower);

        DateTime GetDueDate();
    }
}