using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class theDictionary
    {
        public static Dictionary<int, string> CallNoList = new Dictionary<int, string>();
        public static Dictionary<int, string> addToDictionary()
        {
            addGeneralities();
            addPhilosophyandpsychology();
            addReligion();
            addSocialsciences();
            addLanguages();
            addNaturalSciencesMathematics();
            addTechnologyorAppliedScience();
            addTheArts();
            addLiteratureAndRhetoric();
            addGeographyAndHistory();
            return CallNoList;
        }

        private static void addGeneralities()
        {
            CallNoList.Add(000, "Generalities");
            CallNoList.Add(001, "Knowledge");
            CallNoList.Add(002, "The book");
            CallNoList.Add(003, "System");
            CallNoList.Add(004, "Data processing Computer science");
        }
        private static void addPhilosophyandpsychology()
        {
            CallNoList.Add(111, "Ontology");
            CallNoList.Add(115, "Time");
            CallNoList.Add(128, "Humankind");
            CallNoList.Add(135, "Dreams & mysteries");
            CallNoList.Add(160, "Logic");
        }
        private static void addReligion()
        {
            CallNoList.Add(201, "Philosophy of Christianity");
            CallNoList.Add(220, "Bible");
            CallNoList.Add(231, "God");
            CallNoList.Add(261, "Social theology");
            CallNoList.Add(296, "Judaism");
        }
        private static void addSocialsciences()
        {
            CallNoList.Add(307, "Communities");
            CallNoList.Add(320, "Political science");
            CallNoList.Add(330, "Economics");
            CallNoList.Add(355, "Military science");
            CallNoList.Add(395, "Etiquette (Manners)");
        }
        private static void addLanguages()
        {
            CallNoList.Add(425, "English grammar");
            CallNoList.Add(445, "French grammar");
            CallNoList.Add(460, "Spanish & Portugese languages");
            CallNoList.Add(469, "Portuguese");
            CallNoList.Add(490, "Other languages");
        }
        private static void addNaturalSciencesMathematics()
        {
            CallNoList.Add(510, "Mathematics");
            CallNoList.Add(532, "Fluid mechanics Liquid mechanics");
        }
        private static void addTechnologyorAppliedScience()
        {
            CallNoList.Add(610, "Medical sciences Medicine");
            CallNoList.Add(660, "Medical sciences Medicine");
        }
        private static void addTheArts()
        {
            CallNoList.Add(700, "The arts");
            CallNoList.Add(718, "Landscape design of cemeteries");
        }
        private static void addLiteratureAndRhetoric()
        {
            CallNoList.Add(800, "Literature & rhetoric");
            CallNoList.Add(830, "Literatures of Germanic languages");
        }
        private static void addGeographyAndHistory()
        {
            CallNoList.Add(900, "Geography & history");
            CallNoList.Add(916, "Africa");
        }
    }
}
