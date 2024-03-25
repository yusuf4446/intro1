using intro1.Busines;
using intro1.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("hello");

        string[] loans = { "kredi 1", "kredi 2", "kredi 3", "kredi 4", "kredi 5", "kredi 6", "kredi 7" };

        for (int i = 0; i < loans.Length; i++)
        {
            Console.WriteLine(loans[i]);

        }

        Course course1 = new Course();
        course1.Name = "c# ";
        course1.Id = 1;

        Course course2 = new Course();
        course2.Name = "java ";
        course2.Id = 2;

        Course course3 = new Course();
        course3.Name = "pyton ";
        course3.Id = 3;



        Course[] courses = { course1, course2, course3 };
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine(courses[i].Name + "......." + courses[i].Id);
        }


        CourseManager courseManager = new();
        Course[] courses2 = courseManager.GetAll();

        for (int i = 0; i < courses2.Length; i++)
        {
            Console.WriteLine(courses2[i].Name + "......." + courses2[i].Id);
        }

        İndividualCustomer customer1 = new İndividualCustomer();
        customer1.CustomerNumber = "4864616468";
        customer1.Nationalıdentity = "5168186168864";
        customer1.FirstName = "yusuf";
        customer1.LastName = "yıldız";
        customer1.Id = 1;

        İndividualCustomer customer2 = new İndividualCustomer();
        customer2.CustomerNumber = "4864616465158";
        customer2.Nationalıdentity = "516818651168864";
        customer2.FirstName = "metin";
        customer2.LastName = "yıldız";
        customer2.Id = 2;

        CorporateCustomer customer3 = new CorporateCustomer();
        customer3.CustomerNumber = "51486186";
        customer3.Id = 3;
        customer3.Name = "Paradise";
        customer3.TaxNumber = "6485159411";

        CorporateCustomer customer4 = new CorporateCustomer();
        customer4.CustomerNumber = "5148326186";
        customer4.Id = 4;
        customer4.Name = "Holiday";
        customer4.TaxNumber = "6775159411";


        BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
        foreach (BaseCustomer customer in customers)
        {
            Console.WriteLine(customer.CustomerNumber);
        }
    }
}