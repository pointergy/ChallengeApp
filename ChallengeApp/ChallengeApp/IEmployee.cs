namespace ChallengeApp
{
    // Co zaimplementowane wpisujemy w interface, same definicje bez logiki
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        Statistics GetStatistics();

        void AddGrade(string grade);

        void AddGrade(float grade);

        void AddGrade(char grade);

    }
}
