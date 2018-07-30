using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace APITestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WebClient c = new WebClient();
            var data = c.DownloadString(@"C://Users//mivy//Documents//Visual Studio 2015//Projects//APITest//file.json");
        
            JObject o = JObject.Parse(data);

            var name = o["Name"];
            bool rel = true;
            var relist = o["CanRelist"];
            var promotions = o["Promotions"][1]["Description"];
            Assert.AreEqual(name, "Carbon credits");
            if(rel.Equals(relist))
            {
                Console.WriteLine(relist + " is correct");
            }
            else
            {
                Console.WriteLine(relist + " is not correct");
            }
        
            Assert.AreEqual(promotions, "Good position in category \n2x larger image in desktop site search results");
            Console.WriteLine(name);
            Console.WriteLine(relist);
            Console.WriteLine(promotions);
        }
    }
}
