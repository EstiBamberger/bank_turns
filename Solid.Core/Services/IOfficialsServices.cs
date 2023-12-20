using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solid.Core.Enteties;

namespace Solid.Core.Services
{
    public interface IOfficialsServices
    {
        List<Official> GetOfficials();

        Official GetById(int id);

        void AddOfficial(Official official);

        void UpdateOfficial(int id, Official official);

        void DeleteOfficial(int id);
    }
}
