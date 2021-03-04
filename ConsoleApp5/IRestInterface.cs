namespace ConsoleApp5
{
    extern alias MyAlias1;

    using MyAlias1::ClassLibrary1;
    using Refit;
    using System.Threading.Tasks;

    public interface IRestInterface
    {
        [Get("/someEndPoint")]
        Task<Response> GetData(Request request);
    }
}