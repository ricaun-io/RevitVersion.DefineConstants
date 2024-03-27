using NUnit.Framework;

namespace RevitVersion.DefineConstants.Tests
{
    public class Tests
    {
#if REVIT2025
        [Test]
        public void Test2025()
        {
            Assert.Pass();
        }
#endif
#if REVIT2024
        [Test]
        public void Test2024()
        {
            Assert.Pass();
        }
#endif
#if REVIT2023
        [Test]
        public void Test2023()
        {
            Assert.Pass();
        }
#endif
#if REVIT2022
        [Test]
        public void Test2022()
        {
            Assert.Pass();
        }
#endif
#if REVIT2021
        [Test]
        public void Test2021()
        {
            Assert.Pass();
        }
#endif
#if REVIT2020
        [Test]
        public void Test2020()
        {
            Assert.Pass();
        }
#endif
#if REVIT2019
        [Test]
        public void Test2019()
        {
            Assert.Pass();
        }
#endif
#if REVIT2018
        [Test]
        public void Test2018()
        {
            Assert.Pass();
        }
#endif
#if REVIT2017
        [Test]
        public void Test2017()
        {
            Assert.Pass();
        }
#endif
    }

    public class TestsOrGreater
    {
#if REVIT2025_OR_GREATER
        [Test]
        public void Test2025OrGreater()
        {
            Assert.Pass();
        }
#endif
#if REVIT2024_OR_GREATER
        [Test]
        public void Test2024OrGreater()
        {
            Assert.Pass();
        }
#endif
#if REVIT2023_OR_GREATER
        [Test]
        public void Test2023OrGreater()
        {
            Assert.Pass();
        }
#endif
#if REVIT2022_OR_GREATER
        [Test]
        public void Test2022OrGreater()
        {
            Assert.Pass();
        }
#endif
#if REVIT2021_OR_GREATER
        [Test]
        public void Test2021OrGreater()
        {
            Assert.Pass();
        }
#endif
#if REVIT2020_OR_GREATER
        [Test]
        public void Test2020OrGreater()
        {
            Assert.Pass();
        }
#endif
#if REVIT2019_OR_GREATER
        [Test]
        public void Test2019OrGreater()
        {
            Assert.Pass();
        }
#endif
#if REVIT2018_OR_GREATER
        [Test]
        public void Test2018OrGreater()
        {
            Assert.Pass();
        }
#endif
#if REVIT2017_OR_GREATER
        [Test]
        public void Test2017OrGreater()
        {
            Assert.Pass();
        }
#endif
    }
}