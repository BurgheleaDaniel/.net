namespace DependencyInversionDatabaseAfter
{
    public class CoursesManager
    {
        private Courses courses;

        public CoursesManager(Data database, Courses courses)
        {
			this.courses = new Courses(database);
        }

        public void PrintAll()
        {
            var courses = this.courses.CourseNames();

            // print courses
        }

        public void PrintIds()
        {
            var courses = this.courses.CourseIds();

            // print courses
        }

        public void PrintById(int id)
        {
            var courses = this.courses.GetCourseById(id);

            // print courses
        }

        public void Search(string substring)
        {
            var courses = this.courses.Search(substring);

            // print courses
        }
    }
}
