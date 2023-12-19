using Microsoft.AspNetCore.Mvc;
using RecursiveWebApi.Interfaces;
using RecursiveWebApi.Models.ViewModel;

namespace RecursiveWebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecursiveController : ControllerBase
    {
        private IStandardService _standardService;
        public RecursiveController(IStandardService standardService) {
            _standardService = standardService;
        }

        [HttpGet]
        public ActionResult<List<StandardViewModel>> GetStandardByParentID(int parentId)
        {
            var result = _standardService.GetStandardByParentId(parentId);
           
                return Ok(result);
        }
    }
}
