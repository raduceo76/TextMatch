using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TextMatch.ViewModels;
using TextMatch.Service;
using Microsoft.Extensions.Logging;
using System.Net;

namespace TextMatch.Controllers
{
    [Produces("application/json")]
    [Route("api/matchString")]
    public class MatchStringController : Controller
    {
        private ILogger<MatchStringController> _logger;
        private readonly IStringMatchService _stringService;

        public MatchStringController(IStringMatchService service, ILogger<MatchStringController> logger)
        {
            _stringService = service;
            _logger = logger;
        }

        [HttpGet("")]
        [Route("findMatch")]
        //[ValidateAntiForgeryToken]
        public IActionResult FindMatches(InputViewModel input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Text and Subtext are required");
            }
            if(input.Subtext.Length > input.Text.Length)
            {
                //ModelState.AddModelError("errorMessage", "Text must be equal or longer than Subtext");
                return BadRequest("Text must be equal or longer than Subtext");
            }
            try
            {
                input.Text = WebUtility.HtmlEncode(input.Text);
                input.Subtext = WebUtility.HtmlEncode(input.Subtext);
                return Ok(_stringService.FindMatchText(input.Text, input.Subtext));
            }
            catch(Exception ex)
            {
                _logger.LogError("Error finding text match", ex);
                return BadRequest("Internal server error");
            }
        }
    }
}