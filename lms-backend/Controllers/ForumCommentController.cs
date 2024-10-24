using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [ApiController]
    [Route("api/v1/forumcomments")]
    public class ForumCommentController : ControllerBase
    {
        private readonly IForumCommentService _forumCommentService;
        public ForumCommentController(IForumCommentService forumCommentService)
        {
            _forumCommentService = forumCommentService;
        }

        [HttpGet("{id}")]
        public ActionResult GetForumCommentById(int id)
        {
            var comment = _forumCommentService.GetForumCommentById(id);

            if (comment == null)
            {
                return NotFound($"This comment with id: {id} not found!");
            }

            return Ok(comment);
        }

        [HttpGet]
        public ActionResult GetAllForumComments()
        {
            var comments = _forumCommentService.GetAllForumComments();

            if (comments == null)
            {
                return NotFound("No Comments Found!");
            }

            return Ok(comments);
        }
    }
}
