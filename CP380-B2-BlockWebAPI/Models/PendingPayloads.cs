using CP380_B1_BlockList.Models;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP380_B2_BlockWebAPI.Models
{
    public class PendingPayloads
    {
        // TODO
        //this class should have a variable that is a List of Payload objects
        public List<Payload> Payloads { get; set; }
    }
}
