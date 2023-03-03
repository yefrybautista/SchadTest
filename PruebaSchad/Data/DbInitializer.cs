using PruebaSchad.Models;

namespace PruebaSchad.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PruebaSchadContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
