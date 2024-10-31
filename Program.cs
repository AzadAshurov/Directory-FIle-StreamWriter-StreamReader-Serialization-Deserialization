using Newtonsoft.Json;

namespace Directory_FIleStreamWriterStreamReaderSerialization_Deserialization
{
    internal class Program
    {
        public static string Path = @"C:\Users\II novbe\Desktop\Directory-FIle-StreamWriter-StreamReader-Serialization-Deserialization\Files\JSON.json";

        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Frog", "Book", "SSD" };

            using (StreamWriter sw = new StreamWriter(Path, false))
            {
                sw.Write(DoSerialize(list));
            }
            Add("Phone samsa");
            Console.WriteLine(Search("Book"));
            Console.WriteLine(Search("ghhsgjiojiorg"));
            Delete(1);



        }

        static void Add(string text)
        {
            List<string> listFromJson = GetJson();

            listFromJson.Add(text);
            using (StreamWriter sw = new StreamWriter(Path, false))
            {
                sw.WriteLine(DoSerialize(listFromJson));
            }
        }

        static string DoSerialize(List<string> list)
        {
            string json = JsonConvert.SerializeObject(list);
            return json;
        }

        static List<string> DoDeserialize(string json)
        {
            List<string> list = JsonConvert.DeserializeObject<List<string>>(json);
            return list;
        }

        static bool Search(string name)
        {
            List<string> listFromJson = GetJson();

            return listFromJson.Contains(name);
        }
        static void Delete(int index)
        {
            List<string> listFromJson = GetJson();

            if (listFromJson.Count() > index)
            {
                listFromJson.RemoveAt(index);
                using (StreamWriter sw = new StreamWriter(Path, false))
                {
                    sw.WriteLine(DoSerialize(listFromJson));
                }
            }
            else
            {
                Console.WriteLine("No such index");
            }
        }
        static List<string> GetJson()
        {
            List<string> listFromJson;
            string json = File.ReadAllText(Path);
            listFromJson = DoDeserialize(json);
            return listFromJson;
        }

    }
}