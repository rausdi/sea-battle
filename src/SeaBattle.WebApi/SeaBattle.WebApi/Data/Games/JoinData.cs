using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaBattle.WebApi.Data.Games
{
    public class JoinData
    {
        [FromRoute]
        public Guid GameID { get; set; }

        [FromBody]
        public String UserName { get; set; }

    }
}
