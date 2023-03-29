using Tema_1.Entities;

namespace Tema_1.Database
{
    public static class StoveDB
    {
        public static List<Stove> stoves = new List<Stove>
        {
            new Stove
            {
                Id = 1,
                Name="Aragaz Electric",
                Weight=50.23,
                Height=90,
                Depth=60,
                Width=60,
                HasGrill=true,
                HasRoaster=true,
                Type=Enums.StoveType.Electric
            },
            new Stove
            {
                Id = 2,
                Name="Aragaz Inductie",
                Weight=40.23,
                Height=90,
                Depth=60,
                Width=60,
                HasGrill=false,
                HasRoaster=false,
                Type=Enums.StoveType.Induction,
            },
            new Stove
            {
                Id = 3,
                Name="Aragaz Gaz",
                Weight=55.23,
                Height=90,
                Depth=60,
                Width=60,
                HasGrill=true,
                HasRoaster=false,
                Type=Enums.StoveType.Gas,
            },
        };
    }
}
