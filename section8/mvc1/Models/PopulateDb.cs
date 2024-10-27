using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvc1.Models
{
    public class PopulateDb
    {
        public static void DataIncludeDB(IApplicationBuilder app)
        {
            DataIncludeDB(
                app.ApplicationServices.GetRequiredService<AppDbContext>());
        }

        public static void DataIncludeDB(AppDbContext context)
        {
            System.Console.WriteLine("Applying migrations...");
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product("Kayak", "Watersports", 275),
                    new Product("Lifejacket", "Watersports", 48.95m),
                    new Product("Soccer Ball", "Soccer", 19.50m),
                    new Product("Corner Flags", "Soccer", 34.95m),
                    new Product("Stadium", "Soccer", 79500),
                    new Product("Thinking Cap", "Chess", 16)
                );
                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data");
            }
        }
    }
}