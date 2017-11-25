using BLL;
using System.Web.Http;

namespace API.Controllers
{
    public class PlayersController : ApiController
    {
        [HttpGet]
        [Route("api/Players")]
        public IHttpActionResult getAll()
        {
            PlayerBL pdb = new PlayerBL();
            var result = pdb.GetAll();
            return Ok(result);

        }
    }
}
