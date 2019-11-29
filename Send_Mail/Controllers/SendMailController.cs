using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Send_Mail.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SendMailController : Controller
    {
        public SendMailController()
        {
           
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<String> Send()
        {
            return "";
        }
    }
}