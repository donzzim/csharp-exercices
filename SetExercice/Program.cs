using System;
using System.Collections.Generic;
using SetExercice.Entities;

Student student1 = new Student(123, "Lucas");
Student student2 = new Student(124, "Mathew");
Student student3 = new Student(125, "John");
Student student4 = new Student(126, "Jordan");
Student student5 = new Student(127, "Mariana");
Student student6 = new Student(128, "Roger");

Instructor instructor1 =  new Instructor(50, "Alex");
Instructor instructor2 =  new Instructor(60, "Albert");

Course A = new Course("Biology");
Course B = new Course("Chemistry");
Course C = new Course("Physics");

instructor1.AddCourse(A);
instructor2.AddCourse(A);
instructor2.AddCourse(A);

student1.EnrollIn(A);
student2.EnrollIn(B);
student3.EnrollIn(A);
student4.EnrollIn(A);
student5.EnrollIn(C);
student6.EnrollIn(A);
