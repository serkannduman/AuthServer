using AuthServer.Core.DTOs;
using SharedLibrary.Dtos;

namespace AuthServer.Core.Services;

public interface IUserService // User ile repository katmanı oluşturmamızın nedeni Identity ile otomatik metotlar geliyor.
{
    Task<Response<UserAppDto>>  CreateUserAsync(CreateUserDto createUserDto);
    Task<Response<UserAppDto>>  GetUserByNameAsync(string userName);
}
