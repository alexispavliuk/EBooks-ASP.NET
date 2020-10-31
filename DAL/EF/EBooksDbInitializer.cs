using System;
using System.Data.Entity;
using DAL.Entities;

namespace DAL.EF
{
    /// <summary>
    /// class that initialize database with some data
    /// </summary>
    public class EBooksDbInitializer : DropCreateDatabaseAlways<EBooksContext>
    {
        protected override void Seed(EBooksContext db)
        {
            db.News.Add(new News { Author = "Ivan Pupkin", Text = "TestHeader1", Date = new DateTime(2020, 9, 30) });
            db.News.Add(new News { Author = "Alexander Pushkin", Text = "TestHeader2", Date = new DateTime(2020, 10, 3) });
            db.News.Add(new News { Author = "Joanne Rowling", Text = "TestHeader3", Date = new DateTime(2020, 10, 6) });
            db.News.Add(new News { Author = "Daniel Defoe", Text = "TestHeader4", Date = new DateTime(2020, 10, 8) });
            db.News.Add(new News { Author = "J. R. R. Tolkien", Text = "TestHeader5", Date = new DateTime(2020, 10, 15) });

            db.Reviews.Add(new Review { Author = "Oleksii", Text = "I like all Harry Potter books", Date = new DateTime(2020, 9, 15) });
            db.Reviews.Add(new Review { Author = "Nikita", Text = "Wow, you have nice website", Date = new DateTime(2020, 9, 30) });
            db.Reviews.Add(new Review { Author = "Dmytro", Text = "Can you add Dan Brown books please?", Date = new DateTime(2020, 10, 5) });
            db.Reviews.Add(new Review { Author = "Vova", Text = "Heil Sagan!", Date = new DateTime(2020, 10, 8) });

            base.Seed(db);
        }

    }
}
