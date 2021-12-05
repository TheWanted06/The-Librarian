using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing.Classes
{
    class LoadList
    {
        public static List<int> callList = new List<int>();
        public static List<string> descList = new List<string>();
        private static object someList;

        public static void getLoad()
        {
            var random = new Random();
            Dictionary<int, string> theSet = theDictionary.addToDictionary();

            int index1 = random.Next(theSet.Count);

            List<int> randomNumbers = new List<int>();
            randomNumbers.Add(index1);

            for (int i = 0; i < 6; i++)
            {
                bool isUnique = true;
                index1 = random.Next(theSet.Count);
                //check if new index1 is in randomNumbers list
                if (randomNumbers.Contains(index1))
                    isUnique = false;
                while (isUnique == false)
                {
                    index1 = random.Next(theSet.Count);
                    if (!randomNumbers.Contains(index1))
                        isUnique = true;

                }
                randomNumbers.Add(index1);
            }

            List<int> callingNumberList = new List<int>();
            List<string> descriptions = new List<string>();

        }
        public static List<int> LoadCallingList(int questioNo)
        {
            bool more;
            if(questioNo %2 == 0)
            {
                more = true;
                callList = addCallList(someList,more);
            }
            else
            {
                more = true;
                callList = addCallList(someList, more);
            }
            return callList;
        }

        private static List<string> addDescription(object someList, bool more)
        {
            
            
            throw new NotImplementedException();
        }

        private static List<int> addCallList(object someList, bool more, Dictionary<int, string> theSet)
        {
            var random = new Random();
            //make use of random numbers
            int index1 = random.Next(theSet.Count);

            List<int> randomNumbers = new List<int>();
            randomNumbers.Add(index1);

            if (more == true)
            {

                for (int i = 0; i < 6; i++)
                {
                    bool isUnique = true;
                    index1 = random.Next(theSet.Count);
                    //check if new index1 is in randomNumbers list
                    if (randomNumbers.Contains(index1))
                        isUnique = false;
                    while (isUnique == false)
                    {
                        index1 = random.Next(theSet.Count);
                        if (!randomNumbers.Contains(index1))
                            isUnique = true;

                    }
                    randomNumbers.Add(index1);
                }
            }
            else
            {

            }
            return randomNumbers;
        }

        public static List<string> LoadDescriptionList(int questioNo)
        {
            bool more;
            if (questioNo % 2 == 0)
            {
                more = true;
                descList = addDescription(someList, more);
            }
            else
            {
                more = true;
                descList = addDescription(someList, more);
            }
            return descList;
        }
    }
}
