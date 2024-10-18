using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [Route("api/v1/forums")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        private readonly IForumService _forumService;

        public ForumController(IForumService forumService)
        {
            _forumService = forumService;
        }

        [HttpGet]
        public ActionResult GetAllForums()
        {
            var forums = _forumService.GetAllForums();

            if (forums == null || !forums.Any())
            {
                return NotFound("Forum not found!");
            }

            return Ok(forums);
        }

        [HttpGet("{forumId}")]
        public ActionResult GetForumById(int forumId)
        {
            var forum = _forumService.GetForumById(forumId);

            if (forum == null)
            {
                return NotFound($"Forum with an id: {forumId} not found!");
            }

            return Ok(forum);
        }
    }
}
