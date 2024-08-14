using SharedClass.DTO;
using static SharedClass.DTO.ServiceResponse;
namespace SharedClass.Contract
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDTO userDTO);
        Task<LoginResponse> LoginAccount(LoginDTO loginDTO);
        //Task <GetResponse> getListAccount(UserDTO userDTO);
    }
}
