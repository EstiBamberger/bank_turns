using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Enteties;

namespace Solid.Core.Repositories
{
    public interface IOfficialsRepositories
    {
        List<Official> GetOfficials();

        Official GetById(int id);

        Official AddOfficial(Official official);

        Official UpdateOfficial(int id, Official official);

        void DeleteOfficial(int id);
    }
}
