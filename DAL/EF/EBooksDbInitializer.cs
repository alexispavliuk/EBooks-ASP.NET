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
            db.News.Add(new News { Author = "Ivan Pupkin", Header = "TestHeader1", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Massa vitae tortor condimentum lacinia quis vel. Adipiscing elit pellentesque habitant morbi. Arcu cursus euismod quis viverra nibh cras pulvinar. Ultricies integer quis auctor elit. Massa sed elementum tempus egestas sed. Urna cursus eget nunc scelerisque. Facilisis leo vel fringilla est ullamcorper eget. Nulla facilisi etiam dignissim diam quis enim lobortis scelerisque. At lectus urna duis convallis convallis tellus id interdum velit. Posuere sollicitudin aliquam ultrices sagittis orci a scelerisque.", Date = new DateTime(2020, 9, 30) });
            db.News.Add(new News { Author = "Alexander Pushkin", Header = "TestHeader2", Text = "Elit sed vulputate mi sit amet mauris commodo quis. Urna nunc id cursus metus aliquam. Arcu dictum varius duis at consectetur lorem donec. Ut etiam sit amet nisl. Nisl vel pretium lectus quam id. Venenatis urna cursus eget nunc scelerisque viverra. Nullam vehicula ipsum a arcu cursus vitae congue mauris. Eros in cursus turpis massa tincidunt dui ut ornare. Vitae proin sagittis nisl rhoncus mattis rhoncus urna. Arcu odio ut sem nulla pharetra diam sit amet nisl. Non odio euismod lacinia at quis risus sed vulputate. Vestibulum lectus mauris ultrices eros. Et pharetra pharetra massa massa ultricies mi quis. Euismod nisi porta lorem mollis. Risus nec feugiat in fermentum. Mauris in aliquam sem fringilla ut morbi.", Date = new DateTime(2020, 10, 3) });
            db.News.Add(new News { Author = "Joanne Rowling", Header = "TestHeader3", Text = "Nisl purus in mollis nunc sed id semper risus. In massa tempor nec feugiat nisl pretium fusce. Tortor pretium viverra suspendisse potenti nullam ac tortor vitae purus. Malesuada nunc vel risus commodo. Feugiat in ante metus dictum. Massa ultricies mi quis hendrerit dolor magna eget est. Arcu odio ut sem nulla. Turpis egestas maecenas pharetra convallis. Turpis massa tincidunt dui ut ornare lectus sit amet. Elementum integer enim neque volutpat ac tincidunt vitae semper. Quam pellentesque nec nam aliquam sem et tortor. Aliquet eget sit amet tellus cras adipiscing enim eu. Velit sed ullamcorper morbi tincidunt ornare massa. Pharetra vel turpis nunc eget lorem dolor sed. Magna fermentum iaculis eu non diam.", Date = new DateTime(2020, 10, 6) });
            db.News.Add(new News { Author = "Daniel Defoe", Header = "TestHeader4", Text = "Ut ornare lectus sit amet est placerat. Id aliquet risus feugiat in ante metus. Pharetra vel turpis nunc eget lorem dolor. Et tortor at risus viverra adipiscing. Pulvinar mattis nunc sed blandit libero volutpat sed cras. Enim tortor at auctor urna nunc id cursus metus. Tortor id aliquet lectus proin nibh nisl condimentum id venenatis. Pellentesque habitant morbi tristique senectus et netus et. Arcu risus quis varius quam quisque id diam. Massa sed elementum tempus egestas sed sed risus pretium. Consectetur a erat nam at lectus. Facilisis magna etiam tempor orci eu lobortis.", Date = new DateTime(2020, 10, 8) });
            db.News.Add(new News { Author = "J. R. R. Tolkien", Header = "TestHeader5", Text = "Bibendum enim facilisis gravida neque convallis a. Non odio euismod lacinia at. Suscipit tellus mauris a diam maecenas sed enim ut. Arcu risus quis varius quam quisque id. Lacinia quis vel eros donec ac odio tempor. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo nec. Mi in nulla posuere sollicitudin. Tristique sollicitudin nibh sit amet commodo. Eget nunc scelerisque viverra mauris in aliquam sem fringilla. Suspendisse in est ante in nibh. Fermentum leo vel orci porta non pulvinar neque laoreet.", Date = new DateTime(2020, 10, 15) });

            db.Reviews.Add(new Review { Author = "Oleksii", Text = "I like all Harry Potter books", Date = new DateTime(2020, 9, 15) });
            db.Reviews.Add(new Review { Author = "Nikita", Text = "Wow, you have nice website", Date = new DateTime(2020, 9, 30) });
            db.Reviews.Add(new Review { Author = "Dmytro", Text = "Can you add Dan Brown books please?", Date = new DateTime(2020, 10, 5) });
            db.Reviews.Add(new Review { Author = "Vova", Text = "Heil Sagan!", Date = new DateTime(2020, 10, 8) });

            base.Seed(db);
        }

    }
}
