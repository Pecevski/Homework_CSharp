using System;

namespace Homework_Class06
{
    #region Task 01 - PhotoAlbum Class
    public class PhotoAlbum
    {
        public PhotoAlbum()
        {
            NumberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }

        private int NumberOfPages;

        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }

    }

    public class BigPhotoAlbum
    {
        public int numberOfPages;
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
    #endregion


    #region Task 2 - FirstCourse, SecondCourse, and Project
    public class FirstCourse
    {
        public FirstCourse(string courseName, bool pass)
        {
            CourseName = courseName;
            passed = pass;
        }

        public bool Passed()
        {
            if (passed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string CourseName;
        public bool passed;
    }

    public class SecondCourse
    {
        public SecondCourse(string courseName, StudentGrades grade)
        {
            CourseName = courseName;
            Grades = grade;
        }

        public string CourseName;
        public StudentGrades Grades;

        public bool Passed()
        {
            if ((int)Grades !=5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Project
    {
        public  Project(bool courseOne, bool courseTwo, bool courseThree, bool courseFour)
        {
            CourseOne = courseOne;
            CourseTwo = courseTwo;
            CourseThree = courseThree;
            CourseFour = courseFour;
        }

        bool CourseOne;
        bool CourseTwo;
        bool CourseThree;
        bool CourseFour;

        public void Passed()
        {
            bool[] array = { CourseOne, CourseTwo, CourseThree, CourseFour };
            int sumOfCourses = 0;

            foreach (var item in array)
            {
                if (item == true)
                {
                    sumOfCourses++;
                }
            }
            if (sumOfCourses > 2)
            {
                Console.WriteLine($"Student has passed, successifully achieving {sumOfCourses} courses! "); ;
            }
            else
            {
                Console.WriteLine("Studend failed!"); ;
            }
        }

    }

    public enum StudentGrades
    {
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5
    }

    #endregion


class Program
    {
        static void Main(string[] args)
        {

            #region Task 01
            PhotoAlbum albumOne = new PhotoAlbum();
            Console.WriteLine(albumOne.GetNumberOfPages());

            PhotoAlbum albumTwo = new PhotoAlbum(24);
            Console.WriteLine(albumTwo.GetNumberOfPages());

            BigPhotoAlbum bigPhotoAlbum = new BigPhotoAlbum();
            Console.WriteLine(bigPhotoAlbum.GetNumberOfPages());

            Console.ReadLine();

            #endregion

            #region Task 02

            var firstCourseOne = new FirstCourse("SEDC", true);
            var firstCourseTwo = new FirstCourse("Seavus", true);

            var secondCourseOne = new SecondCourse("Coding", StudentGrades.Ten);
            var seocndCourseTwo = new SecondCourse("Brainster", StudentGrades.Six);

            Project Grades = new Project(firstCourseOne.Passed(), firstCourseTwo.Passed(), secondCourseOne.Passed(), seocndCourseTwo.Passed());

            Grades.Passed();

            Console.ReadLine();

            #endregion

        }
    }
}
