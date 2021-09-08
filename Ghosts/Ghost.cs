using System.Collections.Generic;
using System.Linq;

namespace Ghosts
{
    public class Ghost
    {
        private string _name;
        private List<Evidence> _evidences;


        public Ghost(string name, List<Evidence> evidences)
        {
            _name = name;
            _evidences = evidences;
        }

        public bool IsAccordance(List<Evidence> evidencesNeed)
        {
            foreach (var evidenceNeed in evidencesNeed)
            {
                if (_evidences.FirstOrDefault(evidence => evidence.ID == evidenceNeed.ID) == null)
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}