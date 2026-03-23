using DictionaryLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace DictionaryTests
{
    [TestClass]
    public class DictionaryTests
    {
        private string testFile = "test_dictionary.txt";
        private string outputFile = "test_output.txt";

        [TestInitialize]
        public void Setup()
        {
            File.WriteAllLines(testFile, new[] { "мама", "папа", "кот", "собака", "дом" }, Encoding.UTF8);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testFile)) File.Delete(testFile);
            if (File.Exists(outputFile)) File.Delete(outputFile);
        }

        [TestMethod]
        public void TestLoadDictionary()
        {
            var slovar = new Slovar(testFile);
            Assert.AreEqual(5, slovar.Count);
        }

        [TestMethod]
        public void TestAddWord()
        {
            var slovar = new Slovar(testFile);
            bool added = slovar.AddWord("новый");
            Assert.IsTrue(added);
            Assert.AreEqual(6, slovar.Count);
        }

        [TestMethod]
        public void TestAddDuplicateWord()
        {
            var slovar = new Slovar(testFile);
            bool added = slovar.AddWord("мама");
            Assert.IsFalse(added);
            Assert.AreEqual(5, slovar.Count);
        }

        [TestMethod]
        public void TestRemoveWord()
        {
            var slovar = new Slovar(testFile);
            bool removed = slovar.RemoveWord("кот");
            Assert.IsTrue(removed);
            Assert.AreEqual(4, slovar.Count);
        }

        [TestMethod]
        public void TestSearchByConsonants()
        {
            var slovar = new Slovar(testFile);
            var results = slovar.SearchByVariant6(2, true); // 2 согласные
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void TestSearchByVowels()
        {
            var slovar = new Slovar(testFile);
            var results = slovar.SearchByVariant6(2, false); // 2 гласные
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void TestFuzzySearch()
        {
            var slovar = new Slovar(testFile);
            var results = slovar.FuzzySearch("мкма", 2);
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void TestSaveResults()
        {
            var slovar = new Slovar(testFile);
            var results = slovar.SearchByPrefix("м");
            bool saved = slovar.SaveSearchResults(results, outputFile);
            Assert.IsTrue(saved);
            Assert.IsTrue(File.Exists(outputFile));
        }

        [TestMethod]
        public void TestEmptySearchResult()
        {
            var slovar = new Slovar(testFile);
            var results = slovar.SearchByVariant6(100, true);
            Assert.AreEqual(0, results.Count);
        }
    }
}