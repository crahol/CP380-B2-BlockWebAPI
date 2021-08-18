using CP380_B1_BlockList.Models;
using CP380_B2_BlockWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CP380_B2_BlockWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PendingPayloadsController : ControllerBase
    {
        // TODO
        [Route("/PendingPayloads")]
        [HttpGet]
        public IActionResult Get()
        {
            Payload newPendingPayloads = new Payload("user", TransactionTypes.GRANT, 10, null);
            return Ok(newPendingPayloads);
        }

        [Route("/PendingPayloads")]
        [HttpPost]
        public IActionResult Post(string user, TransactionTypes t, int amount, string item)
        {
            Payload newPayload = new(user, t, amount, item);
            return Ok(newPayload);
        }
    }
}
