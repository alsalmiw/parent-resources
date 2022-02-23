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
    public class WeeklyChallengesController : ControllerBase
    {
        private readonly WeeklyChallengesServices _data;

        public WeeklyChallengesController(WeeklyChallengesServices dataFromService){
            _data = dataFromService;
        }
    }
}