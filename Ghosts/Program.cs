using System;
using System.Collections.Generic;

namespace Ghosts
{
    internal class Program
    {
        private static List<Ghost> _ghosts;

        public static void Main(string[] args)
        {
            _ghosts = new List<Ghost>();

            Ghost ghost1 = new Ghost("Ghost [1,2,3]",
                new List<Evidence>()
                {
                    new Evidence(1, "1"),
                    new Evidence(2, "2"),
                    new Evidence(3, "3")
                });

            Ghost ghost2 = new Ghost("Ghost [2,3,4]",
                new List<Evidence>()
                {
                    new Evidence(2, "2"),
                    new Evidence(3, "3"),
                    new Evidence(4, "4")
                });

            Ghost ghost3 = new Ghost("Ghost [5,6,1]",
                new List<Evidence>()
                {
                    new Evidence(5, "5"),
                    new Evidence(6, "6"),
                    new Evidence(1, "1")
                });

            _ghosts.Add(ghost1);
            _ghosts.Add(ghost2);
            _ghosts.Add(ghost3);

            List<Evidence> playerEvidences = new List<Evidence>()
            {
                new Evidence(2, "2"),
                new Evidence(1, "1")
            };

            GetGhostWithEvidence(playerEvidences).ForEach(ghost => Console.WriteLine(ghost.ToString()));
        }

        private static List<Ghost> GetGhostWithEvidence(List<Evidence> evidences)
        {
            List<Ghost> ghostsFound = new List<Ghost>();
            _ghosts.ForEach(ghost =>
            {
                if (ghost.IsAccordance(evidences))
                {
                    ghostsFound.Add(ghost);
                }
            });
            return ghostsFound;
        }
    }
}