namespace DotNetLearningApp.Services.SchoolService
{
    public class SchoolService : ISchool
    {
        private static List<School> schools = new List<School>
            {
                new School
                {
                    Id = 1,
                    Year = 10,
                    Name = "FPT"
                },
                new School
                {
                    Id = 2,
                    Year = 10,
                    Name = "VLU"
                },
                new School
                {
                    Id = 3,
                    Name = "CPU"
                }
            };

        public int AddSchool(School request)
        {
            schools.Add(request);

            return request.Id;
        }

        public List<School> DeleteSchool(int id)
        {
            School school = schools.Find(x => x.Id == id);

            if (school is null)
            {
                return null;
            }

            schools.Remove(school);

            return schools;
        }

        public List<School> EditSchool(int id, School request)
        {
            School school = schools.Find(x => x.Id == id);

            if (school is null)
            {
                return null;
            }

            school.Id = request.Id;
            school.Name = request.Name;
            school.Location = request.Location;

            return schools;
        }

        public List<School> GetAllSchool()
        {
            var result = from school in schools
                         orderby school.Id, school.Year
                         select school;
            return result.ToList();
        }

        public School GetOneSchool(int id)
        {
            School school = schools.Find(x => x.Id == id);

            return school;
        }
    }
}
