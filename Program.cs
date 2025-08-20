
using HtmlAgilityPack;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter url:");
        string url = Console.ReadLine();
        Console.WriteLine("enter tag:");
        string tag = Console.ReadLine();
        //maybe try to implement more threads?
       // Console.WriteLine("enter thread number:");
        //int threadNumber = int.Parse(Console.ReadLine());
        //Console.WriteLine($"//{tag}");
        Thread thread=new Thread(()=>CrawlSite(url,tag));
        thread.Start();
        thread.Join();
    }

    static void CrawlSite(string url, string tag)
    {
        try
        {   
            using (HttpClient client = new HttpClient())
            {
                var html = client.GetStringAsync(url).Result;
                //Console.WriteLine(html);
                HtmlDocument document = new HtmlDocument();
                document.LoadHtml(html);
                var nodes = document.DocumentNode.SelectNodes($"//{tag}");
            
                int count = nodes?.Count ?? 0;
                Console.WriteLine($"tag <{tag}>  appears {count} times on {url}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}