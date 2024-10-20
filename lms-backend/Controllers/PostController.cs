using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [ApiController]
    [Route("api/v1/posts")]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("{id}")]
        public ActionResult GetPostById(int id)
        {
            var post = _postService.GetPostById(id);

            if (post == null)
            {
                return NotFound($"Post with id: {id} not found!");
            }

            return Ok(post);
        }

        [HttpGet]
        public ActionResult GetAllPosts()
        {
            var posts = _postService.GetAllPosts();

            if (posts == null)
            {
                return NotFound("No Posts Found!");
            }

            return Ok(posts);
        }
    }
}
