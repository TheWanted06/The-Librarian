using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Librarian.Classes
{
    class HighScoreList
    {
        private class ScoreNode
        {
            public string theUser { get; set; }
            public int theScore { get; set; }

            ScoreNode(User user1)
            {
                theScore = user1.Score;
                theUser = user1.Username;
            }
        }
        private ScoreNode headScore;
        private ScoreNode tailScore;
        private int count;

        HighScoreList()
        {
            headScore = null;
            tailScore = null;
            count = 0;
        }


    }
}
