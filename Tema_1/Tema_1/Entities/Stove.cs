using Tema_1.Enums;

namespace Tema_1.Entities
{
    public class Stove
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public StoveType Type  { get; set; }
        public bool HasGrill { get; set; }
        public bool HasRoaster { get; set; }

    }
}
