internal class Program
{
    private static void Main(string[] args)
    {
        string url = Console.ReadLine();
        int protocolIndex = url.IndexOf("://");

        string protocol;
        string serverAndResource;
        if (protocolIndex != -1)
        {
            protocol = url.Substring(0, protocolIndex);
            serverAndResource = url.Substring(protocolIndex + 3);
        }
        else
        {
            protocol = string.Empty;
            serverAndResource = url;
        }

        string server;
        string resource;
        if (serverAndResource.IndexOf("/") != -1)
        {
            server = serverAndResource.Substring(0, serverAndResource.IndexOf("/"));
            resource = serverAndResource.Substring(serverAndResource.IndexOf("/") + 1);
        } else
        {
            server = serverAndResource;
            resource = string.Empty;
        }



        Console.WriteLine($"{protocol} \n {server} \n {resource}");
    }
}