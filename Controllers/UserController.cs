using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using parent_learning_resources_webapi.Services;

namespace parent_learning_resources_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserServices _data;

        public UserController (UserServices dataFromService)
        {
            _data = dataFromService;
        }
    }
}