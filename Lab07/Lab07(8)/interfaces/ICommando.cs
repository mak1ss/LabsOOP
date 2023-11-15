using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_8_.interfaces
{
    internal interface ICommando : ISpecialisedSoldier
    {
        ICollection<IMission> Missions { get; }

        void CompleteMission(string missionCodeName);
    }
}
