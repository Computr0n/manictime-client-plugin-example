using System;
using ManicTime.TFS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TagPlugin.Tests
{
    [TestClass]
    public class TfsTests
    {
        [TestMethod]
        public void GetProjects()
        {
            var query = new ExecuteQuery();
            var workItems = query.RunGetBugsQueryUsingClientLib();
        }
    }
}
