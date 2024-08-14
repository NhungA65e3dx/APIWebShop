using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClass.DTO
{
    public class ServiceResponse
    {
        public record class GeneralResponse (bool Flag, string Message);
        public record class LoginResponse (bool Flag,string Token, string Message);
      //  public record class GetResponse (bool Flag,string Message);
    }
}
