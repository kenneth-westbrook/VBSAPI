using Microsoft.AspNetCore.Mvc;

namespace AWSServerless1.Controllers
{
    [Route("vbsapi")]
    [ApiController]
    public class VBSAPIController : ControllerBase
    {
        [HttpGet]
        [Route("GetStatementsByVeteranID")]
        public IActionResult GetStatementsByVeteranID()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetStations")]
        public IActionResult GetStations()
        {
            return Ok();
        }
    }
}