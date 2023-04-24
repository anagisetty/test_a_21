using System;

namespace Test_a_21
{
    public class RenewalDataRepository
    {
        private readonly Test_a_21Context _context;

        public RenewalDataRepository(Test_a_21Context context)
        {
            _context = context;
        }
        
        public void Create(RenewalData data)
        {
            _context.RenewalData.Add(data);
            _context.SaveChanges();
        }

        public RenewalData Read(int id)
        {
            return _context.RenewalData.Find(id);
        }

        public void Update(RenewalData data)
        {
            _context.RenewalData.Update(data);
            _context.SaveChanges();
        }

        public void Delete(RenewalData data)
        {
            _context.RenewalData.Remove(data);
            _context.SaveChanges();
        }

        public IEnumerable<RenewalData> GetAllBefore1stJan2020()
        {
            return _context.RenewalData.Where(x => x.RenewalDate < new DateTime(2020, 1, 1)).ToList();
        }
    }
}