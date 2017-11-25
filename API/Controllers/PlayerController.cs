using BLL;
using System;
using System.Web.Http;

namespace API.Controllers
{
    public class PlayerController : ApiController
    {

        [HttpGet]
        [Route("api/Player/{Id}")]
        public IHttpActionResult getById(Guid Id)
        {
            PlayerBL pdb = new PlayerBL();
            var result = pdb.GetById(Id);
            return Ok(result);

        }

        [HttpGet]
        [Route("api/Player/get/{email}")]
        public IHttpActionResult getByEmail([FromUri] String email)
        {
            PlayerBL pdb = new PlayerBL();
            var result = pdb.GetByEmail(email);
            return Ok(result);

        }
    }
}
