using APIWebShop.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedClass.Contract;
using SharedClass.DTO;
using APIWebShop.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using log4net;
using log4net.Config;
using log4net.Core;
using System.Reflection;

namespace APIWebShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    [Authorize]

    public class AccountController(IUserAccount userAccount) : ControllerBase
    {


        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDTO userDTO)
        {
            var response = await userAccount.CreateAccount(userDTO);
            return Ok(response);
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginAccount(LoginDTO loginDTO)
        {
            var response = await userAccount.LoginAccount(loginDTO);
            return Ok(response);
        }
        private void LogError(string message)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
            ILog _logger = LogManager.GetLogger(typeof(LoggerManager));
            _logger.Info(message);
        }
    }
}
