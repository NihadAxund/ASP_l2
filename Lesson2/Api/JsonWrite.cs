using Lesson2.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson2.Api
{
    public static class JsonWrite
    {
        public static List<Person> ReadAsync(string filePath = "Api/PersonList.json")
        {
            string jsonString = File.ReadAllText(filePath);
            var vlaie = JsonConvert.DeserializeObject<List<Person>>(jsonString);
            return JsonConvert.DeserializeObject<List<Person>>(jsonString); ;
        }

        public static async Task<bool>  WriteAsync(Person Data)
        {
            var list = ReadAsync();
            if (list == null) {
                list = new List<Person>();
            }
            else if (list.Count>=1) {

                 if (list.Exists(x=>x==Data))
                 {
                     return false;
                 }
            }
           
            list.Add(Data);
            string fileName = "Api/PersonList.json";
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(fileName, json);
            return true;
        }
    }
}
