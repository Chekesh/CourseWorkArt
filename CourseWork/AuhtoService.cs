using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public class AuhtoService
    {

        public AuhtoService() { }
        public String InstructorORStudent(String login, String pass, int res)
        {
            String user = "USER";
            if (!string.IsNullOrWhiteSpace(login))
            {
                if (!string.IsNullOrWhiteSpace(pass))
                {
                    if (res == 1)
                    {
                        user = "STUDENT";
                    }
                    else if (res == 2)
                    {
                        user = "INSTRUCTOR";
                    }
                    else
                    {
                        MessageBox.Show("Пользоватяля с такими данными не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //открытие 2 фрэйма
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return user;
        }
    }
}
