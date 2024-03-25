using intro1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro1.Busines;

public class CourseManager
{
    Course[] Courses=new Course[3];
    public CourseManager()
    {

        Course course1 = new Course();
        course1.Name = "c# ";
        course1.Id = 1;

        Course course2 = new Course();
        course2.Name = "java ";
        course2.Id = 2;

        Course course3 = new Course();
        course3.Name = "pyton ";
        course3.Id = 3;

       
         Courses[0] = course1;
        Courses[1] = course2;
        Courses[2] = course3;

    }
    public Course[] GetAll()
    {
        return Courses;
    }
    

}
