using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_prac1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperatureController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly TempData TempData;

        public TemperatureController(TempData TempData)
        {

            this.TempData = TempData;
        }


        [HttpPost]
        public IActionResult Create([FromQuery] int TempVal, [FromQuery] string DT)
        {
            TempData.TempInfo.Add(new TempInfo
            {
                DateTime = DateTime.ParseExact(DT, "dd.MM.yyyy HH:mm", null),
                TempVal = TempVal,
            });

            return Ok();
        }

        [HttpGet("readd")]
        public IActionResult Read([FromQuery] string DateTimeStart, [FromQuery] string DateTimeFinish)
        {
            var read_list = new List<TempInfo>();

            read_list = TempData.TempInfo.Where(w => (w.DateTime >= DateTime.ParseExact(DateTimeStart, "dd.MM.yyyy HH:mm", null)) & (w.DateTime <= DateTime.ParseExact(DateTimeFinish, "dd.MM.yyyy HH:mm", null))).ToList();

            return Ok(read_list);
        }

        [HttpGet("reads")]
        public IActionResult Read()
        { 

            return Ok(TempData.TempInfo);
        }

        [HttpPut]
        public IActionResult Update([FromQuery] string DateTimeToUpdate, [FromQuery] int newTempValue)
        {
            foreach(var tm in TempData.TempInfo)
            {
                if (tm.DateTime == DateTime.ParseExact(DateTimeToUpdate, "dd.MM.yyyy HH:mm", null)
)
                    tm.TempVal = newTempValue;
            }

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] string DateTimeStart, [FromQuery] string DateTimeFinish)
        {
            TempData.TempInfo = TempData.TempInfo.Where(w => (w.DateTime < DateTime.ParseExact(DateTimeStart, "dd.MM.yyyy HH:mm", null)) | (w.DateTime > DateTime.ParseExact(DateTimeFinish, "dd.MM.yyyy HH:mm", null))).ToList();

            return Ok(TempData.TempInfo);
        }




    }
}
