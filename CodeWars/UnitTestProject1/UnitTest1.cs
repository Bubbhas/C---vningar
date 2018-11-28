using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars.Katas;

namespace UnitTestProject1
{
    
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NextBigNumberTest()
        {
            Assert.AreEqual(21, NextBigNumberKata.NextBiggerNumber(12));
            Assert.AreEqual(531, NextBigNumberKata.NextBiggerNumber(513));
            Assert.AreEqual(2071, NextBigNumberKata.NextBiggerNumber(2017));
            Assert.AreEqual(441, NextBigNumberKata.NextBiggerNumber(414));
            Assert.AreEqual(127918, NextBigNumberKata.NextBiggerNumber(127891));
            Assert.AreEqual(1234567908, NextBigNumberKata.NextBiggerNumber(1234567890));
        }

        [TestMethod]
        public void CountingDublicatesTest()
        {
            Assert.AreEqual(0, CountingDublicates.DuplicateCount(""));
            Assert.AreEqual(0, CountingDublicates.DuplicateCount("abcde"));
            Assert.AreEqual(2, CountingDublicates.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, CountingDublicates.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, CountingDublicates.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, CountingDublicates.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }



        [TestMethod]
        public void CleanStringTest()
        {
            Assert.AreEqual("ac", BackspacesInString.CleanString("abc#d##c"));
            Assert.AreEqual("", BackspacesInString.CleanString("abc####d##c#"));
        }
        

        [TestMethod]
        public void YourOrderPleaseTest()
        {
            Assert.AreEqual("Thi1s is2 3a T4est", YourOrderPlease.Order("is2 Thi1s T4est 3a"));
            Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", YourOrderPlease.Order("4of Fo1r pe6ople g3ood th5e the2"));
            Assert.AreEqual("", YourOrderPlease.Order(""));
        }


        [TestMethod]
        public void SpinsStrings()
        {
            Assert.AreEqual("emocleW", SpinTheWords.SpinsWord("Welcome"));
        }


        [TestMethod]
        public void MultiplesofThreeAndFive()
        {
            Assert.AreEqual(23, MultiplesOf3And5.MultiplesOfThreeAndFive(10));
        }



        [TestMethod]
        public void AlphabetWarTest()
        {
            Assert.AreEqual("Right side wins!", AlphabetWars.AlphabetWar("z"));
            Assert.AreEqual("Let's fight again!", AlphabetWars.AlphabetWar("zdqmwpbs"));
            Assert.AreEqual("Right side wins!", AlphabetWars.AlphabetWar("zzzzs"));
            Assert.AreEqual("Left side wins!", AlphabetWars.AlphabetWar("wwwwwwz"));
        }


        [TestMethod]
        public void RPSLPTest()
        {
            //player 1 won
            Assert.AreEqual("Player 1 won!", RPSLP1.RPSLP("rock", "scissor"));
            Assert.AreEqual("Player 1 won!", RPSLP1.RPSLP("scissor", "lizard"));
            Assert.AreEqual("Player 1 won!", RPSLP1.RPSLP("paper", "spock"));
        }



        [TestMethod]
        public void FirstNonRepeatingLetterTest()
        {
            Assert.AreEqual("a", firstNonRepeatingLetters.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", firstNonRepeatingLetters.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", firstNonRepeatingLetters.FirstNonRepeatingLetter("moonmen"));
            Assert.AreEqual("T", firstNonRepeatingLetters.FirstNonRepeatingLetter("sTreSS"));
            Assert.AreEqual("", firstNonRepeatingLetters.FirstNonRepeatingLetter("abba"));
        }


        //[TestMethod]
        //public void ScrambliesTest()
        //{
        //    Assert.AreEqual(Scramblies.Scramblie("rkqodlw", "world"), true);
        //    Assert.AreEqual(Scramblies.Scramblie("cedewaraaossoqqyt", "codewars"), true);
        //    Assert.AreEqual(Scramblies.Scramblie("katas", "steak"), false);
        //    Assert.AreEqual(Scramblies.Scramblie("scriptjavx", "javascript"), false);
        //    Assert.AreEqual(Scramblies.Scramblie("scriptingjava", "javascript"), true);
        //    Assert.AreEqual(Scramblies.Scramblie("scriptsjava", "javascripts"), true);
        //    Assert.AreEqual(Scramblies.Scramblie("javscripts", "javascript"), false);
        //    Assert.AreEqual(Scramblies.Scramblie("aabbcamaomsccdd", "commas"), true);
        //    Assert.AreEqual(Scramblies.Scramblie("commas", "commas"), true);
        //    Assert.AreEqual(Scramblies.Scramblie("sammoc", "commas"), true);
        //}




        [TestMethod]
        public void PigLatinTest()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", PigLatin.SimplePigLatin("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", PigLatin.SimplePigLatin("This is my string"));
        }
    }
}
