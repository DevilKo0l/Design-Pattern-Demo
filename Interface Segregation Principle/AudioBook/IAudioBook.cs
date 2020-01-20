namespace Interface_Segregation_Principle
{
    internal interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}