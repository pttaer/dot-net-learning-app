namespace DotNetLearningApp.Models
{
    public class School
    {
        public int Id { get; set; }
        public int Year { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}
