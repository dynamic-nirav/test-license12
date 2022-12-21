using Microsoft.AspNetCore.Mvc;
using NIF.License.API;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NIF.License.Creation.API.Controllers
{
    /// <summary>
    /// License APIs for the Operation to be performed for the License Creation
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LicenseController : ControllerBase
    {
        /// <summary>
        /// To Get list of All the License
        /// </summary>
        /// <returns></returns>
        // GET: api/<LicenseController>
        [HttpGet]
        public IEnumerable<LicenseStub> Get()
        {
            List<LicenseStub> stubs = new List<LicenseStub>()
            {
                new LicenseStub
                {
                    Id = 1,
                    Name = "American football license senior",
                Description = "Senior players from the year they turn 18",
                AutoRenew = true,
                Price = 1250,
                RenewBefore = 5,
                   StartDate = (DateTime.Now).AddDays(100),
                EndDate = (DateTime.Now).AddDays(320)
                },
                  new LicenseStub
                {
                      Id = 2,
                    Name = "American football training license half a year",
                Description = "for training license half a year",
                AutoRenew = true,
                Price = 2250,
                RenewBefore = 5,
                StartDate = (DateTime.Now).AddDays(100),
                      EndDate = (DateTime.Now).AddDays(282)

                }
        };
            return stubs;

        }
    }
}
