using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English
{
    class Gamedata
    {
        string[,] Ans = new string[10, 5];
        string[] Ques = new string[10];
        private void TaoQues()
        {
            Ques[1] = "I have an .........";
            Ques[2] = "A few of them felt that proper ......... facility would help them to sell their produce in a big way";
            Ques[3] = "Remember that ......., like any other skill, is something that you can improve at with study and practice";
            Ques[4] = "A bad ........ makes a bad ending";
            Ques[5] = "There is no ...... without fire";
            Ques[6] = "It is the ...... step that is troublesome";
            Ques[7] = "Every ......... loves to hear himself sing";
            Ques[8] = "The ......... they are, the harder they fall";
            Ques[9] = "......... often ends in love, but love in .......... – never";
            Ques[0] = "The FBI agent is tough, smart, and a ......... of disguise";
        }
        private void TaoAns()
        {
            Ans[1, 1] = "Apple";
            Ans[1, 2] = "Lemon";
            Ans[1, 3] = "Grape";
            Ans[1, 4] = "Mango";

            Ans[2, 1] = "Marketing";
            Ans[2, 2] = "Building";
            Ans[2, 3] = "Training";
            Ans[2, 4] = "Managing";

            Ans[3, 1] = "Management";
            Ans[3, 2] = "Talent";
            Ans[3, 3] = "Treatment";
            Ans[3, 4] = "Entertainment";

            Ans[4, 1] = "Begining";
            Ans[4, 2] = "Playing";
            Ans[4, 3] = "Trying";
            Ans[4, 4] = "Joining";

            Ans[5, 1] = "Smoke";
            Ans[5, 2] = "Water";
            Ans[5, 3] = "Air";
            Ans[5, 4] = "Dust";

            Ans[6, 1] = "First";
            Ans[6, 2] = "Second";
            Ans[6, 3] = "Last";
            Ans[6, 4] = "One";

            Ans[7, 1] = "Bird";
            Ans[7, 2] = "Cat";
            Ans[7, 3] = "Lion";
            Ans[7, 4] = "Dog";

            Ans[8, 1] = "Bigger";
            Ans[8, 2] = "Better";
            Ans[8, 3] = "Stronger";
            Ans[8, 4] = "Smaller";

            Ans[9, 1] = "Friendship";
            Ans[9, 2] = "Leadership";
            Ans[9, 3] = "Partnership";
            Ans[9, 4] = "Relationship";

            Ans[0, 1] = "Master";
            Ans[0, 2] = "Panda";
            Ans[0, 3] = "Omega";
            Ans[0, 4] = "Physics";
        }
        public Gamedata()
        {
            TaoQues();
            TaoAns();
        }

        public string XuatQ(int a)
        {
            string Q = Ques[a];
            return Q;
        }
        public string XuatA(int a,int b)
        {
            string A = Ans[a,b];
            return A;
        }
    }
}
