using System.Web.Http;
using System.Web.Http.Cors;
using ReshServer.Services;
using ReshServer.ReshService;

namespace ReshServer.Controllers
{
    //usikker på om dette er riktig måte å gjøre det på 
    [EnableCors(origins: "http://reshclient.azurewebsites.net", headers: "*", methods: "*")]

    public class ReshController : ApiController
    {
        private ReshRepository reshRepository;

        public ReshController()
        {
            this.reshRepository = new ReshRepository();
        }

        public ReshUnit Get(int id)
        {
            return this.reshRepository.getUnitById(id);
        }
    }
}
