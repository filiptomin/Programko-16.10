using db2.data;
using System;
using System.Linq;

namespace db2
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDBContext db = new ApplicationDBContext();
            
            db.SaveChanges();
            
            
            var cUser = db.Students.Where(s => s.FirstName.Contains("D")).FirstOrDefault();
            if (cUser != null)
            {
                db.Students.Remove(cUser);
                db.SaveChanges();
            }
            foreach (var xd in db.Classrooms.ToList())
            {
                foreach (var st in db.Students.ToList())
                {
                    Console.WriteLine(xd.ID + ": " + xd.Name + " ", xd.Students + " ");
                    Console.WriteLine(st.ID + ": " + st.FirstName + " " + st.LastName);
                }
               
            }
           
            Console.ReadKey();
        }
    }
}
