using Tema_1.Database;
using Tema_1.Entities;

namespace Tema_1.Repository
{
    public class StoveRepository
    {
        public void AddStove(Stove stove)
        {
            StoveDB.stoves.Add(stove);
        }

        public void DeleteStove(int id)
        {
            var result = StoveDB.stoves.Find(x => x.Id == id);
            StoveDB.stoves.Remove(result);
        }

        public List<Stove> GetAllStoves()
        {
            var result = StoveDB.stoves;
            return result;
        }

        public Stove? GetStoveById(int id)
        {
            var result = StoveDB.stoves.Find(x => x.Id == id);
            return result;
        }

        public void UpdateMotorcycle(Stove stove)
        {
            var dbStove = StoveDB.stoves.Find(x => x.Id == stove.Id);

            if (dbStove is not null)
            {
                dbStove.Name = stove.Name;
                dbStove.Weight = stove.Weight;
                dbStove.Width= stove.Width;
                dbStove.Height = stove.Height;
                dbStove.Depth = stove.Depth;
                dbStove.Type= stove.Type;
                dbStove.HasGrill= stove.HasGrill;
                dbStove.HasRoaster= stove.HasRoaster;
            }
        }

    }
}
