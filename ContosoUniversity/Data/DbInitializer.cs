﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            //        context.Database.EnsureCreated();

            //        // Look for any students.
            //        if (context.Students.Any())
            //        {
            //            return;   // DB has been seeded
            //        }

            //        var students = new Student[]
            //        {
            //        new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            //        new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //        new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //        new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //        new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //        new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            //        new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //        new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            //        };
            //        foreach (Student s in students)
            //        {
            //            context.Students.Add(s);
            //        }
            //        context.SaveChanges();

            //        var courses = new Course[]
            //        {
            //        new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            //        new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            //        new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            //        new Course{CourseID=1045,Title="Calculus",Credits=4,},
            //        new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            //        new Course{CourseID=2021,Title="Composition",Credits=3,},
            //        new Course{CourseID=2042,Title="Literature",Credits=4,}
            //        };
            //        foreach (Course c in courses)
            //        {
            //            context.Courses.Add(c);
            //        }
            //        context.SaveChanges();

            //        var enrollments = new Enrollment[]
            //        {
            //        new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            //        new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            //        new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            //        new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            //        new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            //        new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            //        new Enrollment{StudentID=3,CourseID=1050},
            //        new Enrollment{StudentID=4,CourseID=1050,},
            //        new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            //        new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            //        new Enrollment{StudentID=6,CourseID=1045},
            //        new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            //        };
            //        foreach (Enrollment e in enrollments)
            //        {
            //            context.Enrollments.Add(e);
            //        }
            //        context.SaveChanges();

            //context.Database.EnsureCreated();

            // Look for any students.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                var students = new Student[]
                {
                    new Student { FirstName = "Carson",   LastName = "Alexander",
                        EnrollmentDate = DateTime.Parse("01.09.2010") },
                    new Student { FirstName = "Meredith", LastName = "Alonso",
                        EnrollmentDate = DateTime.Parse("01.09.2012") },
                    new Student { FirstName = "Arturo",   LastName = "Anand",
                        EnrollmentDate = DateTime.Parse("01.09.2013") },
                    new Student { FirstName = "Gytis",    LastName = "Barzdukas",
                        EnrollmentDate = DateTime.Parse("01.09.2012") },
                    new Student { FirstName = "Yan",      LastName = "Li",
                        EnrollmentDate = DateTime.Parse("01.09.2012") },
                    new Student { FirstName = "Peggy",    LastName = "Justice",
                        EnrollmentDate = DateTime.Parse("01.09.2011") },
                    new Student { FirstName = "Laura",    LastName = "Norman",
                        EnrollmentDate = DateTime.Parse("01.09.2013") },
                    new Student { FirstName = "Nino",     LastName = "Olivetto",
                        EnrollmentDate = DateTime.Parse("01.09.2005") }
                };

                foreach (Student s in students)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();

                var instructors = new Instructor[]
                {
                    new Instructor { FirstMidName = "Kim",     LastName = "Abercrombie",
                        HireDate = DateTime.Parse("11.03.1995") },
                    new Instructor { FirstMidName = "Fadi",    LastName = "Fakhouri",
                        HireDate = DateTime.Parse("06.07.2002") },
                    new Instructor { FirstMidName = "Roger",   LastName = "Harui",
                        HireDate = DateTime.Parse("01.07.1998") },
                    new Instructor { FirstMidName = "Candace", LastName = "Kapoor",
                        HireDate = DateTime.Parse("15.01.2001") },
                    new Instructor { FirstMidName = "Roger",   LastName = "Zheng",
                        HireDate = DateTime.Parse("12.02.2004") }
                };

                foreach (Instructor i in instructors)
                {
                    context.Instructors.Add(i);
                }
                context.SaveChanges();

                var departments = new Department[]
                {
                    new Department { Name = "English",     Budget = 350000,
                        StartDate = DateTime.Parse("01.09.2007"),
                        InstructorID  = instructors.Single( i => i.LastName == "Abercrombie").ID },
                    new Department { Name = "Mathematics", Budget = 100000,
                        StartDate = DateTime.Parse("01.09.2007"),
                        InstructorID  = instructors.Single( i => i.LastName == "Fakhouri").ID },
                    new Department { Name = "Engineering", Budget = 350000,
                        StartDate = DateTime.Parse("01.09.2007"),
                        InstructorID  = instructors.Single( i => i.LastName == "Harui").ID },
                    new Department { Name = "Economics",   Budget = 100000,
                        StartDate = DateTime.Parse("01.09.2007"),
                        InstructorID  = instructors.Single( i => i.LastName == "Kapoor").ID }
                };

                foreach (Department d in departments)
                {
                    context.Departments.Add(d);
                }
                context.SaveChanges();

                var courses = new Course[]
                {
                    new Course {CourseID = 1050, Title = "Chemistry",      Credits = 3,
                        DepartmentID = departments.Single( s => s.Name == "Engineering").DepartmentID
                    },
                    new Course {CourseID = 4022, Title = "Microeconomics", Credits = 3,
                        DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID
                    },
                    new Course {CourseID = 4041, Title = "Macroeconomics", Credits = 3,
                        DepartmentID = departments.Single( s => s.Name == "Economics").DepartmentID
                    },
                    new Course {CourseID = 1045, Title = "Calculus",       Credits = 4,
                        DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID
                    },
                    new Course {CourseID = 3141, Title = "Trigonometry",   Credits = 4,
                        DepartmentID = departments.Single( s => s.Name == "Mathematics").DepartmentID
                    },
                    new Course {CourseID = 2021, Title = "Composition",    Credits = 3,
                        DepartmentID = departments.Single( s => s.Name == "English").DepartmentID
                    },
                    new Course {CourseID = 2042, Title = "Literature",     Credits = 4,
                        DepartmentID = departments.Single( s => s.Name == "English").DepartmentID
                    },
                };

                foreach (Course c in courses)
                {
                    context.Courses.Add(c);
                }
                context.SaveChanges();

                var officeAssignments = new OfficeAssignment[]
                {
                    new OfficeAssignment {
                        InstructorID = instructors.Single( i => i.LastName == "Fakhouri").ID,
                        Location = "Smith 17" },
                    new OfficeAssignment {
                        InstructorID = instructors.Single( i => i.LastName == "Harui").ID,
                        Location = "Gowan 27" },
                    new OfficeAssignment {
                        InstructorID = instructors.Single( i => i.LastName == "Kapoor").ID,
                        Location = "Thompson 304" },
                };

                foreach (OfficeAssignment o in officeAssignments)
                {
                    context.OfficeAssignments.Add(o);
                }
                context.SaveChanges();

                var courseInstructors = new CourseAssignment[]
                {
                    new CourseAssignment {
                        CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                        InstructorID = instructors.Single(i => i.LastName == "Kapoor").ID
                        },
                    new CourseAssignment {
                        CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                        InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                        },
                    new CourseAssignment {
                        CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID,
                        InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                        },
                    new CourseAssignment {
                        CourseID = courses.Single(c => c.Title == "Macroeconomics" ).CourseID,
                        InstructorID = instructors.Single(i => i.LastName == "Zheng").ID
                        },
                    new CourseAssignment {
                        CourseID = courses.Single(c => c.Title == "Calculus" ).CourseID,
                        InstructorID = instructors.Single(i => i.LastName == "Fakhouri").ID
                        },
                    new CourseAssignment {
                        CourseID = courses.Single(c => c.Title == "Trigonometry" ).CourseID,
                        InstructorID = instructors.Single(i => i.LastName == "Harui").ID
                        },
                    new CourseAssignment {
                        CourseID = courses.Single(c => c.Title == "Composition" ).CourseID,
                        InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
                        },
                    new CourseAssignment {
                        CourseID = courses.Single(c => c.Title == "Literature" ).CourseID,
                        InstructorID = instructors.Single(i => i.LastName == "Abercrombie").ID
                        },
                };

                foreach (CourseAssignment ci in courseInstructors)
                {
                    context.CourseAssignments.Add(ci);
                }
                context.SaveChanges();

                var enrollments = new Enrollment[]
                {
                        new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Alexander").ID,
                        CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                        Grade = Grade.A
                        },
                        new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Alexander").ID,
                        CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID,
                        Grade = Grade.C
                        },
                        new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Alexander").ID,
                        CourseID = courses.Single(c => c.Title == "Macroeconomics" ).CourseID,
                        Grade = Grade.B
                        },
                        new Enrollment {
                            StudentID = students.Single(s => s.LastName == "Alonso").ID,
                        CourseID = courses.Single(c => c.Title == "Calculus" ).CourseID,
                        Grade = Grade.B
                        },
                        new Enrollment {
                            StudentID = students.Single(s => s.LastName == "Alonso").ID,
                        CourseID = courses.Single(c => c.Title == "Trigonometry" ).CourseID,
                        Grade = Grade.B
                        },
                        new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Alonso").ID,
                        CourseID = courses.Single(c => c.Title == "Composition" ).CourseID,
                        Grade = Grade.B
                        },
                        new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Anand").ID,
                        CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID
                        },
                        new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Anand").ID,
                        CourseID = courses.Single(c => c.Title == "Microeconomics").CourseID,
                        Grade = Grade.B
                        },
                        new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Barzdukas").ID,
                        CourseID = courses.Single(c => c.Title == "Chemistry").CourseID,
                        Grade = Grade.B
                        },
                        new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Li").ID,
                        CourseID = courses.Single(c => c.Title == "Composition").CourseID,
                        Grade = Grade.B
                        },
                        new Enrollment {
                        StudentID = students.Single(s => s.LastName == "Justice").ID,
                        CourseID = courses.Single(c => c.Title == "Literature").CourseID,
                        Grade = Grade.B
                        }
                };

                foreach (Enrollment e in enrollments)
                {
                    var enrollmentInDataBase = context.Enrollments.Where(
                        s =>
                                s.Student.ID == e.StudentID &&
                                s.Course.CourseID == e.CourseID).SingleOrDefault();
                    if (enrollmentInDataBase == null)
                    {
                        context.Enrollments.Add(e);
                    }
                }
                context.SaveChanges();
        }

    }
}