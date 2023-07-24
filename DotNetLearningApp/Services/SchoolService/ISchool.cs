namespace DotNetLearningApp.Services.SchoolService
{
    public interface ISchool
    {
        List<School> GetAllSchool();
        School? GetOneSchool(int id);
        int AddSchool(School request);
        List<School>? EditSchool(int id, School request);
        List<School>? DeleteSchool(int id);
    }
}
