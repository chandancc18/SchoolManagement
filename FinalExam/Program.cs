using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("On which Table Would you like to perform Operation\n1.Student\n2.Teacher\n3.Course\n4.Standard\n5.StudentAddress\n6.Quit");
            int a = Int32.Parse(Console.ReadLine());
            while (a != 6)
            {
                if (a == 1)
                {
                    Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Search by Name\n5.Grades Report\n6.Display Table\n7.Exit to Main");
                    int b = Int32.Parse(Console.ReadLine());
                    while (b != 7) {
                        if (b == 1)
                        {
                            InsertStudent();
                        }
                        else if (b == 2)
                        {
                            UpdateStudent();
                        }
                        else if (b == 3)
                        {
                            DeleteStudent();
                        }
                        else if (b == 4)
                        {
                            GetStudentByName();
                        }
                        else if (b == 5)
                        {
                            getGrades();
                        }
                        else if (b == 6)
                        {
                            DisplayStudentInfo();
                        }
                        else
                            Console.WriteLine("Enter number between 1 to 7 only");

                        Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Search by Name\n5.Count total Grades\n6.Display Table\n7.Exit to Main");
                         b = Int32.Parse(Console.ReadLine());
                    }

                }
                else if (a == 2)
                {
                    Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Search by Name\n5.Display Table\n6.Exit to Main");
                    int b = Int32.Parse(Console.ReadLine());
                    while (b != 6)
                    {
                        if (b == 1)
                        {
                            InsertTeacher();
                        }
                        else if (b == 2)
                        {
                            UpdateTeacher();
                        }
                        else if (b == 3)
                        {
                            DeleteTeacher();
                        }
                        else if (b == 4)
                        {
                            GetTeacherByName();
                        }
                        else if (b == 5)
                        {
                            DisplayTeacher();
                        }
                        else
                            Console.WriteLine("Enter number between 1 to 6 only");

                        Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Search by Name\n5.Display Table\n6.Exit to Main");
                         b = Int32.Parse(Console.ReadLine());
                    }

                }
                else if (a == 3)
                {
                    Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Read\n5.Exit To Main Menu");
                    int b = Int32.Parse(Console.ReadLine());
                    while (b != 5)
                    {
                        if (b == 1)
                        {
                            InsertCourse();
                        }
                        else if (b == 2)
                        {
                            UpdateCourse();
                        }
                        else if (b == 3)
                        {
                            DeleteCourse();
                        }
                        else if (b == 4)
                        {
                            DisplayCourse();
                        }

                        else
                            Console.WriteLine("Enter number between 1 to 5 only");

                        Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Read\n5.Exit To Main Menu");
                         b = Int32.Parse(Console.ReadLine());
                    }
                }

                else if (a == 4)
                {
                    Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Read\n5.Exit To Main Menu");
                    int b = Int32.Parse(Console.ReadLine());
                    while (b != 5)
                    {
                        if (b == 1)
                        {
                            InsertStandard();
                        }
                        else if (b == 2)
                        {
                            UpdateStandard();
                        }
                        else if (b == 3)
                        {
                            DeleteStandard();
                        }
                        else if (b == 4)
                        {
                            DisplayStandard();
                        }
                        else
                            Console.WriteLine("Enter number between 1 to 5 only");

                        Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Read\n5.Exit To Main Menu");
                         b = Int32.Parse(Console.ReadLine());
                    }
                }
                else if (a == 5)
                {
                    Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Read\n5.Exit to Main Menu");
                    int b = Int32.Parse(Console.ReadLine());
                    while (b != 5)
                    {
                        if (b == 1)
                        {
                            InsertStudentAddress();
                        }
                        else if (b == 2)
                        {
                            UpdateStudentAddress();
                        }
                        else if (b == 3)
                        {
                            DeleteStudentAddress();
                        }
                        else if (b == 4)
                        {
                            DisplayStudentAddress();
                        }
                        else
                            Console.WriteLine("Enter number between 1 to 5 only");

                        Console.WriteLine("What would you like to do\n1.Insert\n2.Update\n3.Delete\n4.Read\n5.Exit To Main Menu");
                         b = Int32.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Enter number between 1 to 6 only");
                }

                Console.WriteLine("On which Table Would you like to perform Operation\n1.Student\n2.Teacher\n3.Course\n4.Standard\n5.StudentAddress\n6.Quit");
                 a = Int32.Parse(Console.ReadLine());
            }

        }


        static void DisplayTeacher()
        {
            using (var context = new SchoolDBEntities())
            {
               
                var teachers = from s in context.Teachers
                                select s;

                foreach (var std in teachers)
                {
                    Console.WriteLine($"{std.TeacherId,5} {std.TeacherName,-20} {std.TeacherType,-20}");
                }
            }
        }
        static void DisplayStudentInfo()
        {
            using (SchoolDBEntities context = new SchoolDBEntities())
            {
               
                var teachers = (from s in context.StudentAddresses
                                join a in context.Students on s.StudentID equals a.StudentID
                                select new
                                {
                                    a.StudentID,
                                    a.StudentName,
                                    s.Address1,
                                    s.City,
                                    s.State
                                }).ToList();
                foreach (var std in teachers)
                {
                    Console.WriteLine($"{std.StudentID,5} {std.StudentName,-20} {std.Address1,-20} {std.City,-20} {std.State,-20}");
                }



            }
        }

        static void DisplayCourse()
        {
            using (var context = new SchoolDBEntities())
            {
                
                var course = from s in context.Courses
                               select s;


                foreach (var std in course)
                {
                    Console.WriteLine($"{std.CourseId,5} {std.CourseName,-20} {std.TeacherId,-20}");
                }
            }
        }

        static void DisplayStudentAddress()
        {
            using (var context = new SchoolDBEntities())
            {
                // LINQ Query Syntax
                var sa = from s in context.StudentAddresses
                             select s;


                foreach (var std in sa)
                {
                    Console.WriteLine($"{std.StudentID,5} {std.Address1,-20} {std.Address2,-20} {std.City,-20} { std.State,-20}");
                }
            }
        }
        static void DisplayStandard()
        {
            using (var context = new SchoolDBEntities())
            {
                // LINQ Query Syntax
                var standard = from s in context.Standards
                               select s;


                foreach (var std in standard)
                {
                    Console.WriteLine($"{std.StandardId,5} {std.StandardName,-20} {std.Description,-20}");
                }
            }
        }

        static void InsertStudent()
        {
            using (var context = new SchoolDBEntities())
            {
                Console.Write("Insert a record\n");
                Console.Write("Enter Student Name");
                String name = Console.ReadLine();

                Student std = new Student();
                std.StudentName = name;

                context.Students.Add(std);
                context.SaveChanges();
            }
        }

        static void InsertStandard()
        {
            using (var context = new SchoolDBEntities())
            {
                Console.Write("Insert a record\n");
                Console.Write("Enter Standard Name\n");
                String name = Console.ReadLine();
                Console.Write("Enter Standard Description");
                String dep = Console.ReadLine();

                Standard std = new Standard();
                std.StandardName = name;
                std.Description = dep;

                context.Standards.Add(std);
                context.SaveChanges();
            }
        }

        static void InsertTeacher()
        {
            using (var context = new SchoolDBEntities())
            {
                Console.Write("Insert a record\n");
                Console.Write("Enter Teacher Name\n");
                String name = Console.ReadLine();
                Console.Write("Enter Teacher Type in (1,2,3)\n");

                int id2 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter StandardId\n");
                int id1 = Int32.Parse(Console.ReadLine());

                
                Standard temp = context.Standards.Find(id1);
                if (temp == null)
                {
                    Console.WriteLine("Invalid Standard Id");

                }
                else
                {

                    Teacher teach = new Teacher();
                    teach.TeacherName = name;
                    teach.StandardId = id1;
                    teach.TeacherType = id2;
                    context.Teachers.Add(teach);
                }
                context.SaveChanges();
            }
        }



        static void InsertCourse()
        {
            using (var context = new SchoolDBEntities())
            {
                Console.Write("Insert a record\n");
                Console.Write("Enter Course Name\n");
                String name = Console.ReadLine();
                Console.Write("Enter TeacherId\n");

                int id1 = Int32.Parse(Console.ReadLine());

                Teacher temp = context.Teachers.Find(id1);
                if (temp == null)
                {
                    Console.WriteLine("Invalid Teacher Id");

                }
                else
                {

                    Course course = new Course();
                    course.CourseName = name;
                    course.Location = null;
                    course.TeacherId = id1;
                    
                    context.Courses.Add(course);
                }
                context.SaveChanges();
            }
        }


        static void InsertStudentAddress()
        {
            using (var context = new SchoolDBEntities())
            {
                Console.Write("Insert a record\n");
                Console.Write("Enter Student Id\n");
                //String name = Console.ReadLine();
               // Console.Write("Enter TeacherId\n");

                int id = Int32.Parse(Console.ReadLine());

                Student temp = context.Students.Find(id);
                if (temp == null)
                {
                    Console.WriteLine("Invalid Student Id");

                }
                else
                {
                    Console.Write("Enter Address 1\n");
                    String add1 = Console.ReadLine();
                    Console.Write("Enter Address 2\n");
                    String add2 = Console.ReadLine();
                    Console.Write("Enter City\n");
                    String city = Console.ReadLine();
                    Console.Write("Enter State\n");
                    String state = Console.ReadLine();
                    StudentAddress sa = new StudentAddress();
                    sa.StudentID=id;
                    sa.Address1 = add1;
                    sa.Address2 = add2;
                    sa.City = city;
                    sa.State = state;
                   context.StudentAddresses.Add(sa);
                }
                context.SaveChanges();
            }
        }
        // method to update an existing student

        static void UpdateStudent()
        {
            using (var context = new SchoolDBEntities())
            {

                Console.WriteLine("Enter the student id of the student to be updated");
                int id1 = Int32.Parse(Console.ReadLine());
                Student std = context.Students.Find(id1);
                if (std == null)
                {
                    Console.WriteLine("Invalid Student Id");

                }
                else
                {
                    Console.WriteLine("Enter the student name");
                    string name = Console.ReadLine();
                   
                    std.StudentName = name;
                }
                Console.WriteLine("Would you like to Update\n Press Y for Yes and N for No ");
                char read = Char.Parse(Console.ReadLine());
                if (read == 'Y' || read == 'y')
                    context.SaveChanges();
                else
                    Console.WriteLine("Update Operation Cancelled");

            }
        }

        static void UpdateTeacher()
        {
            using (var context = new SchoolDBEntities())
            {
                Console.WriteLine("Enter the teacher id of the teacher to be updated");
                int id1 = Int32.Parse(Console.ReadLine());
                Teacher tea = context.Teachers.Find(id1);
                if (tea == null)
                {
                    Console.WriteLine("Invalid Teacher Id");

                }
                else
                {
                    Console.Write("Enter Teacher Name\n");
                    String name = Console.ReadLine();
                    Console.Write("Enter Teacher Type in (1,2,3)\n");
                    int id2 = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter StandardId\n");
                    int id3 = Int32.Parse(Console.ReadLine());

               
                    Standard temp = context.Standards.Find(id3);
                    if (temp == null)
                    {
                        Console.WriteLine("Invalid Standard Id");

                    }
                    else
                    {

                        tea.TeacherName = name;
                        tea.StandardId = id3;
                        tea.TeacherType = id2;
                    }
                    Console.WriteLine("Would you like to Update\n Press Y for Yes and N for No ");
                    char read = Char.Parse(Console.ReadLine());
                    if (read == 'Y' || read == 'y')
                        context.SaveChanges();
                    else
                        Console.WriteLine("Update Operation Cancelled");
                }
            }
        }

        static void UpdateCourse()
        {
            using (var context = new SchoolDBEntities())
            {
                Console.WriteLine("Enter the course id of the course to be updated");
                int id1 = Int32.Parse(Console.ReadLine());
                Course c = context.Courses.Find(id1);
                if (c == null)
                {
                    Console.WriteLine("Invalid Course Id");

                }
                else
                {
                    Console.Write("Enter Course Name\n");
                    String name = Console.ReadLine();
                    Console.Write("Enter TeacherId\n");
                    int id = Int32.Parse(Console.ReadLine());


                    Teacher temp = context.Teachers.Find(id);
                    if (temp == null)
                    {
                        Console.WriteLine("Invalid Teacher Id");

                    }
                    else
                    {

                        c.CourseName= name;
                        c.TeacherId = id;
                       
                    }
                    Console.WriteLine("Would you like to Update\n Press Y for Yes and N for No ");
                    char read = Char.Parse(Console.ReadLine());
                    if (read == 'Y' || read == 'y')
                        context.SaveChanges();
                    else
                        Console.WriteLine("Update Operation Cancelled");
                }
            }
        }

        static void UpdateStudentAddress()
        {
            using (var context = new SchoolDBEntities())
            {

                Console.WriteLine("Enter the student id of the student to be updated");
                int id = Int32.Parse(Console.ReadLine());
                StudentAddress sa = context.StudentAddresses.Find(id);
                if (sa == null)
                {
                    Console.WriteLine("Invalid Student Id");

                }
                else
                {
                    Console.Write("Enter Address 1\n");
                    String add1 = Console.ReadLine();
                    Console.Write("Enter Address 2\n");
                    String add2 = Console.ReadLine();
                    Console.Write("Enter City\n");
                    String city = Console.ReadLine();
                    Console.Write("Enter State\n");
                    String state = Console.ReadLine();
                    sa.StudentID = id;
                    sa.Address1 = add1;
                    sa.Address2 = add2;
                    sa.City = city;
                    sa.State = state;
                }
                Console.WriteLine("Would you like to Update\n Press Y for Yes and N for No ");
                char read = Char.Parse(Console.ReadLine());
                if (read == 'Y' || read == 'y')
                    context.SaveChanges();
                else
                    Console.WriteLine("Update Operation Cancelled");
            }
        }

        static void UpdateStandard()
        {
            using (var context = new SchoolDBEntities())
            {

                Console.WriteLine("Enter the sandard id  to be updated");
                int id1 = Int32.Parse(Console.ReadLine());
                Standard std = context.Standards.Find(id1);
                if (std == null)
                {
                    Console.WriteLine("Invalid Standard Id");

                }
                else
                {
                    Console.WriteLine("Enter the standard name\n");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the standard description");
                    string dep = Console.ReadLine();

                    std.StandardName = name;
                    std.Description = dep;
                }
                Console.WriteLine("Would you like to Update\n Press Y for Yes and N for No ");
                char read = Char.Parse(Console.ReadLine());
                if (read == 'Y' || read == 'y')
                    context.SaveChanges();
                else
                    Console.WriteLine("Update Operation Cancelled");

            }
        }




        // method to delete an existing student
        static void DeleteStudent()
            {
                using (var context = new SchoolDBEntities())
                {


                    Console.WriteLine("Enter the student id of the student to be deleted");
                    int id1 = Int32.Parse(Console.ReadLine());
                    Student std = context.Students.Find(id1);
                    if (std == null)
                    {
                        Console.WriteLine("Invalid User Id");

                    }
                    else
                    {
                        context.Students.Remove(std);
                    }
                Console.WriteLine("Would you like to Delete\n Press Y for Yes and N for No ");
                char read = Char.Parse(Console.ReadLine());
                if (read == 'Y' || read == 'y')
                    context.SaveChanges();
                else
                    Console.WriteLine("Delete Operation Cancelled");
            }
            }

        static void DeleteTeacher()
        {
            using (var context = new SchoolDBEntities())
            {


                Console.WriteLine("Enter the Teacher id of the Teacher to be deleted");
                int id1 = Int32.Parse(Console.ReadLine());
                Teacher std = context.Teachers.Find(id1);
                if (std == null)
                {
                    Console.WriteLine("Invalid Teacher Id");

                }
                else
                {
                    context.Teachers.Remove(std);
                }
                Console.WriteLine("Would you like to Delete\n Press Y for Yes and N for No ");
                char read = Char.Parse(Console.ReadLine());
                if (read == 'Y' || read == 'y')
                    context.SaveChanges();
                else
                    Console.WriteLine("Delete Operation Cancelled");
            }
        }
        

        static void DeleteCourse()
        {
            using (var context = new SchoolDBEntities())
            {


                Console.WriteLine("Enter the Course id of the Course to be deleted");
                int id1 = Int32.Parse(Console.ReadLine());
                Course std = context.Courses.Find(id1);
                if (std == null)
                {
                    Console.WriteLine("Invalid Course Id");

                }
                else
                {
                    context.Courses.Remove(std);
                }
                Console.WriteLine("Would you like to Delete\n Press Y for Yes and N for No ");
                char read = Char.Parse(Console.ReadLine());
                if (read == 'Y' || read == 'y')
                    context.SaveChanges();
                else
                    Console.WriteLine("Delete Operation Cancelled");
            
             }
        }

        static void DeleteStudentAddress()
        {
            using (var context = new SchoolDBEntities())
            {


                Console.WriteLine("Enter the student id of the student to be deleted");
                int id1 = Int32.Parse(Console.ReadLine());
                StudentAddress std = context.StudentAddresses.Find(id1);
                if (std == null)
                {
                    Console.WriteLine("Invalid User Id");

                }
                else
                {
                    context.StudentAddresses.Remove(std);
                }
                Console.WriteLine("Would you like to Delete\n Press Y for Yes and N for No ");
                char read = Char.Parse(Console.ReadLine());
                if (read == 'Y' || read == 'y')
                    context.SaveChanges();
                else
                    Console.WriteLine("Delete Operation Cancelled");
            }
        }

        static void DeleteStandard()
        {
            using (var context = new SchoolDBEntities())
            {


                Console.WriteLine("Enter the standard id  to be deleted");
                int id1 = Int32.Parse(Console.ReadLine());
                Standard std = context.Standards.Find(id1);
                if (std == null)
                {
                    Console.WriteLine("Invalid User Id");

                }
                else
                {
                    context.Standards.Remove(std);
                }
                Console.WriteLine("Would you like to Delete\n Press Y for Yes and N for No ");
                char read = Char.Parse(Console.ReadLine());
                if (read == 'Y' || read == 'y')
                    context.SaveChanges();
                else
                    Console.WriteLine("Delete Operation Cancelled");
            }
        }

        static void GetStudentByName()
        {
            using (var context = new SchoolDBEntities())

            {
                Console.Write("Enter Student Name\n");
                String name = Console.ReadLine();
                // LINQ Query Syntax
               

                var student=from s in context.StudentAddresses
                                join a in context.Students on s.StudentID equals a.StudentID
                                where (a.StudentName == name)
                                orderby a.StudentID
                                 select new
                                {
                                    a.StudentID,
                                    a.StudentName,
                                    s.Address1,
                                    s.City,
                                    s.State
                                };


                foreach (var std in student)
                {
                    Console.WriteLine($"{std.StudentID,5} {std.StudentName,-20} {std.Address1,-20} {std.City,-20} {std.State,-20}");
                }

              //  String adddd = Console.ReadLine();
            }
        }

        static void GetTeacherByName()
        {
            using (var context = new SchoolDBEntities())

            {
                Console.Write("Enter Teacher Name\n");
                String name = Console.ReadLine();
                // LINQ Query Syntax


                var teacher = from s in context.Teachers
                              where s.TeacherName == name
                              orderby s.TeacherId
                              select s;

                foreach (var std in teacher)
                {
                    Console.WriteLine($"{std.TeacherId,5} {std.TeacherName,-20} {std.TeacherType,-20}");
                }
            }
        }

        static void getGrades()
        {
            using (var context = new SchoolDBEntities())
            {
                Console.WriteLine("Enter Student Id");
                int id = Int32.Parse(Console.ReadLine());

                Student temp = context.Students.Find(id);
                if (temp == null)
                {
                    Console.WriteLine("Invalid Student Id");

                }
                else
                {

                    Console.Write("Enter Maths Grades\n");
                    double maths = Double.Parse(Console.ReadLine());
                    Console.Write("Enter Physics Grades\n");
                    double phy = Double.Parse(Console.ReadLine());
                    Console.Write("Enter Chemistry Grades\n");
                    double chem = Double.Parse(Console.ReadLine());

                    double sum = maths + phy + chem;
                    double average = sum / 3;
                    
                        Console.WriteLine($"Student ID :{temp.StudentID,-20}\nStudent Name:{temp.StudentName,5}\nStandard Id:{temp.StandardId,-20}\nTotal Grade:{sum}\nAverage:{average}");

                    
                }

                
            }
        }






    }
}



