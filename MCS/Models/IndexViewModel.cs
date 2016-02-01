using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Helpers;
using System.Xml.Linq;
using System.Xml.XPath;

namespace MCS.Models
{
    public class GIndexViewModel
    {

        public List<List<string>> FilesList()
        {

            return (System.IO.Directory.EnumerateFiles("c:\\Users\\andy\\Desktop\\ForgeServer\\mods")
                .Select(s => new List<string> { s.Substring(s.LastIndexOf("\\") + 1) }).ToList());

        }

        public List<List<string>> FilesListJ()
        {

            return
                (System.IO.Directory.EnumerateFiles("c:\\Users\\andy\\Desktop\\ForgeServerJosh\\mods")
     .Select(s => new List<string> { s.Substring(s.LastIndexOf("\\") + 1) }).ToList());

        }

        public List<string> JoshOps()
        {
            List<string> outPut = new List<string>();
          string fileData =  System.IO.File.ReadAllText("c:\\Users\\andy\\Desktop\\ForgeServerJosh\\ops.json");
  
            // For that you will need to add reference to System.Web.Helpers
            dynamic json = System.Web.Helpers.Json.Decode(fileData);
            foreach (var v in json)
            {
                outPut.Add(v.name);
            }
            return outPut;

        }

        public List<string> MforgeOps()
        {
            List<string> outPut = new List<string>();
            string fileData = System.IO.File.ReadAllText("c:\\Users\\andy\\Desktop\\ForgeServer\\ops.json");

            // For that you will need to add reference to System.Web.Helpers
            dynamic json = System.Web.Helpers.Json.Decode(fileData);
            foreach (var v in json)
            {
                outPut.Add(v.name);
            }
            return outPut;

        }

        public List<string> VOps()
        {
            List<string> outPut = new List<string>();
            string fileData = System.IO.File.ReadAllText("c:\\Users\\andy\\Desktop\\MCServer\\ops.json");

            // For that you will need to add reference to System.Web.Helpers
            dynamic json = System.Web.Helpers.Json.Decode(fileData);
            foreach (var v in json)
            {
                outPut.Add(v.name);
            }
            return outPut;

        }
    }
}