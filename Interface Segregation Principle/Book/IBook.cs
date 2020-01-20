namespace Interface_Segregation_Principle
{
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int pages { get; set; }
    }
}