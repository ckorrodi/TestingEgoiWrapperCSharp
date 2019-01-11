using System;
using Egoi;


namespace testWrapper
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EgoiApi api = EgoiApiFactory.getApi(Protocol.Rest);
            EgoiMap arguments = new EgoiMap();
            arguments.Add("apikey", "e20272f0238fa96e52fdddebef8a0062c57f207b");
            //arguments.Add("apikey", "a049d48858962f0252b9f707269d16d94c6e25c2");
            arguments.Add("listID", "1");
            arguments.Add("subscriber", "ppinto%2B96_2%40e-goi.com");
            try
            {
                EgoiMap result = api.removeSubscriber(arguments);
                Console.WriteLine(result.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("DONE!");
        }
    }
}