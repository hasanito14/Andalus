using BLL;
using BOL;
using System;
using System.Web.Http;

namespace API.Controllers
{
    public class RoleController : ApiController
    {
        [HttpGet]
        [Route("api/Role/{Id}")]
        public IHttpActionResult getById([FromUri] Guid Id)
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

        [HttpPut]
        [Route("api/Player}")]
        public IHttpActionResult Update([FromBody] Player player)
        {
            PlayerBL pdb = new PlayerBL();
            var result = pdb.Update(player);
            return Ok(result);

        }

        [HttpPost]
        [Route("api/Player}")]
        public IHttpActionResult Add([FromBody] Player player)
        {
            PlayerBL pdb = new PlayerBL();
            var result = pdb.Add(player);
            return Ok(result);

        }

        [HttpDelete]
        [Route("api/Player}")]
        public IHttpActionResult Delete([FromUri] Guid Id)
        {
            PlayerBL pdb = new PlayerBL();
            var result = pdb.Delete(Id);
            return Ok(result);

        }
    }
}
