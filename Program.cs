using Newtonsoft.Json;

namespace Directory__FIle__StreamWriter__StreamReader__Serialization__Deserialization
{
    internal class Program
    {
        public string Path = @"C:\Users\Baku\Desktop\Directory, FIle, StreamWriter, StreamReader, Serialization, Deserialization\Files\JSON.json";
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
           {
               "Azad","Azad2","Azad3","Azad4"
           };
            string result = JsonConvert.SerializeObject(list);
            Console.WriteLine(result);
            Console.WriteLine(JsonConvert.DeserializeObject(result));

        }
        static void DoSerialize()
        {

        }
        static void DoDeserialize(List<string> list)
        {


        }
    }
}
