﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeTableManagementAPI.Models;
using TimeTableManagementAPI.Repository;

namespace TimeTableManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeTableController : Controller
    {
        ICommonRepository<Time_Table> _timeTableRepo;
        public TimeTableController(ICommonRepository<Time_Table> timeTableRepo)
        {
            _timeTableRepo = timeTableRepo;
        }

        public IActionResult GetAllTimeTables()
        {
            var result = _timeTableRepo.GetAll("Time_table");
            if (result != null)
                return Ok(result);
            else
                return BadRequest("No time tables Found");
            
        }

        [HttpPost]
        public IActionResult CreateATimeTable(Time_Table time_Table)
        {
            return null;
        }

        [HttpDelete]
        public IActionResult DeleteATimeTable(int Id)
        {
            var result=_timeTableRepo.DeleteRecord("Time_Table",Id);
            if(result)
                return Ok();
            else
                return BadRequest("Record not deleted");
        }

        [HttpPut]
        public IActionResult UpdateATimeTable()
        {
            return null;
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult GetAllDetailsRelatedToATimeTable()
        {
            return null;
        }
    }
}