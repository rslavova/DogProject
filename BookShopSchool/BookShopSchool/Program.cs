using BookShopSchool.Data;

namespace BookShopSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var context=new BookShopSchoolContext();
            context.Database.EnsureCreated();   
        }
    }
}