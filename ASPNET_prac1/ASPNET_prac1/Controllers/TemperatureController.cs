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

        private readonly TemperatureData _temperatureData;

        public TemperatureController(TemperatureData temperatureData)
        {

            this._temperatureData = temperatureData;
        }

        [HttpPost]
        public IActionResult Create([FromQuery] int temperatureValue, [FromQuery] string dateTimeString)
        {
            _temperatureData.TemperatureInfoList.Add(new TemperatureInfo
            {
                TemperatureDateTime = DateTime.ParseExact(dateTimeString, "dd.MM.yyyy HH:mm", null),
                TemperatureValue = temperatureValue,
            });

            return Ok();
        }

        [HttpGet("readd")]
        public IActionResult Read([FromQuery] string dateTimeStart, [FromQuery] string dateTimeFinish)
        {
            var read_list = new List<TemperatureInfo>();

            read_list =
                _temperatureData.TemperatureInfoList.Where
                (w => (w.TemperatureDateTime >= DateTime.ParseExact(dateTimeStart, "dd.MM.yyyy HH:mm", null)) 
                & (w.TemperatureDateTime <= DateTime.ParseExact(dateTimeFinish, "dd.MM.yyyy HH:mm", null))).ToList();

            return Ok(read_list);
        }

        [HttpGet("reads")]
        public IActionResult Read()
        { 

            return Ok(_temperatureData.TemperatureInfoList);
        }

        [HttpPut]
        public IActionResult Update([FromQuery] string dateTimeToUpdate, [FromQuery] int newTemperatureVal)
        {
            foreach(var tm in _temperatureData.TemperatureInfoList)
            {
                if (tm.TemperatureDateTime == DateTime.ParseExact(dateTimeToUpdate, "dd.MM.yyyy HH:mm", null)
)
                    tm.TemperatureValue = newTemperatureVal;
            }

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] string DateTimeStart, [FromQuery] string DateTimeFinish)
        {
            _temperatureData.TemperatureInfoList 
                = _temperatureData.TemperatureInfoList.Where(w => 
                (w.TemperatureDateTime < DateTime.ParseExact(DateTimeStart, "dd.MM.yyyy HH:mm", null)) | 
                (w.TemperatureDateTime > DateTime.ParseExact(DateTimeFinish, "dd.MM.yyyy HH:mm", null))).ToList();

            return Ok(_temperatureData.TemperatureInfoList);
        }
    }
}
