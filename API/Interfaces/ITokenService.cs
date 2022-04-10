using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
        string CreateToeken(AppUser user);
    }
}