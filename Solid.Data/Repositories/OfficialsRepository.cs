using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Enteties;
using Solid.Core.Repositories;

namespace Solid.Data.Repositories
{
    public class OfficialsRepository:IOfficialsRepositories
    {
        private readonly DataContext _context;

        public OfficialsRepository(DataContext context)
        {
            _context = context;
        }
        public Official AddOfficial(Official official)
        {
            _context.Officials.Add(official);
            return official;
        }

        public void DeleteOfficial(int id)
        {
            var temp = _context.Officials.ToList().Find(x => x.Id == id);
            _context.Officials.Remove(temp);
        }

        public List<Official> GetOfficials()
        {
            return _context.Officials.ToList();
        }

        public Official GetById(int id)
        {
            return _context.Officials.ToList().Find(u => u.Id == id);
        }

        public Official UpdateOfficial(int id, Official official)
        {
            var temp = _context.Officials.ToList().Find(u => u.Id == id);
            if(temp != null)
            {
                temp.Id = id;
                temp.Name = official.Name;
            }
            return temp;
        }
    }
}
