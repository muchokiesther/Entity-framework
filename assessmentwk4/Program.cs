using UserData;

using (MyContext context = new MyContext())
{
    context.Database.EnsureCreated();
}