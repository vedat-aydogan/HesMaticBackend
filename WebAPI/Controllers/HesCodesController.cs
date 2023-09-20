using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HesCodesController : ControllerBase
    {
        IHesCodeService _hesCodeService;

        public HesCodesController(IHesCodeService hesCodeService)
        {
            _hesCodeService = hesCodeService;
        }

        [HttpPost("add")]
        public IActionResult Add(HesCode hesCode)
        {
            var result = _hesCodeService.Add(hesCode);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        //[Authorize(Roles ="hescodes.getall")]
        public IActionResult GetAll()
        {
            var result = _hesCodeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _hesCodeService.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("gethescodesoftodaybyuserid")]
        public IActionResult GetHesCodesOfTodayByUserId(int userId)
        {
            var result = _hesCodeService.GetHesCodesOfTodayByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("gethescodesbydaterange")]
        public IActionResult GetHesCodesByDateRange(int userId, DateTime startDate, DateTime endDate)
        {
            var result = _hesCodeService.GetHesCodesByDateRange(userId, startDate, endDate);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
