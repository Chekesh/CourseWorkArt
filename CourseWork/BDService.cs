using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseWork
{
    public interface BDService
    {
        InstructorsClass GetInstructor();
        StudentClass GetStudent();
        void SelectLesson(DataGridView dt, int instructor);
        bool IsStudent(User user, int id_user);
        List<InfStudent> GetStudentInfo();
        List<Lesson> AllLessonFree(int id_instructor);
        bool UpdateLesson(int id_lesson, int id_student);
        bool IsInstructors(User user, int id_user);
        bool CreateLess(int id_instructor, string date, string time);
        List<InstructorsClass> AllInstructors();
        int IsUserBD(string login, string password);
    }
}
