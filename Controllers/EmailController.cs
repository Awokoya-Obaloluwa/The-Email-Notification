using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;

namespace Email__And__Sms__Notification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase

    {
        private readonly IEmailServices _emailServices;

        public EmailController(IEmailServices emailServices)
        {
            this._emailServices = emailServices;
        }




        [HttpPost]
        public IActionResult sendEmail(EmailDto request)
        {
            _emailServices.SendEmail(request);
            return Ok();
        }

    }
}
