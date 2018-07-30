using Newtonsoft.Json;
using System.Web;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net;
using Newtonsoft.Json.Linq;

namespace APITest
{
    class Program
    {
        static void Main(string[] args)
        {

            WebClient c = new WebClient();
            var data = c.DownloadString(@"C://Users//mivy//Documents//Visual Studio 2015//Projects//APITest//file.json");
            JObject o = JObject.Parse(data);
            Console.WriteLine("Name: " + o["Name"]);
            Console.WriteLine("CanRelist: " + o["CanRelist"]);
            Console.WriteLine("Promotions: " + o["Promotions"][1]["Description"]);

            Console.WriteLine(o.Count);


            Console.ReadLine();

        }
    }
}


            //var client = new RestClient("https://api.tmsandbox.co.nz/");
            //// client.Authenticator = new HttpBasicAuthenticator(username, password);

            //var request = new RestRequest("v1/Categories/6327/Details.json?catalogue=false", Method.GET);
            //////request.AddParameter("id", "351286"); // adds to POST or URL querystring based on Method
            ////request.AddUrlSegment("id", "351286"); // replaces matching token in request.Resource

            ////// execute the request
            //IRestResponse response = client.Execute(request);
            //var content = response.Content; // raw content as string
            //Console.WriteLine(response.Content.ToString());

            //using (StreamReader r = new StreamReader(@"C://Users//mivy//Documents//Visual Studio 2015//Projects//APITest//file.json"))
            //{
            //    string json = r.ReadToEnd();
            //    List<RootObject> items = JsonConvert.DeserializeObject <List<RootObject>>(json);
            //    //JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            //    foreach(var arr in items)
            //    {
            //        string result =  arr["Name"].ToString();
            //    }


            //    Console.WriteLine(result);
            //    Console.ReadKey();

            //    //foreach (var item in array)
            //    //{
            //    //    Console.WriteLine("{0} {1}", item.Name, item.id);
            //    //    Console.ReadKey();
            //    //}
            //}


  