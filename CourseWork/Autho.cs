using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{
    public partial class FromAuthorization : Form
    {
        BDService Connection;
        AuhtoService service;
        public FromAuthorization(BDService con)
        {
            Connection = con;
            InitializeComponent();
            this.service = new AuhtoService();
        }

        private void CenterControlInPanel(Control control, Control container)
        {
            int x = (container.ClientSize.Width - control.Width) / 2;
            int y = (container.ClientSize.Height - control.Height);
            control.Location = new Point(x, y);
        }
        public void entrance_Click(object sender, EventArgs e)
        {
            String user = service.InstructorORStudent(login.Text, pass.Text, Connection.IsUserBD(login.Text, pass.Text));
            if(user == "STUDENT")
            {
                Student form = new Student(this, Connection);
                form.ShowDialog();
            }
            else if(user == "INSTRUCTOR")
            {
                Instructors form = new Instructors(this, Connection);
                form.ShowDialog();
            }
        }

        private void FromAuthorization_SizeChanged(object sender, EventArgs e)
        {
            CenterControlInPanel(panel1, this);
        }
    }
}
