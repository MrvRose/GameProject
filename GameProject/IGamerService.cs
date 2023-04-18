using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void UpDate(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
