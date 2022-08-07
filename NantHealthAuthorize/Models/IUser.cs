
namespace NantHealthAuthorize.Models
{
    public interface IUser
    {
        Guid id { get; set; }
        string password { get; set; }
        string username { get; set; }
        ILoginLogic LoginLogic { get; set; } 
}