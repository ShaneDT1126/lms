﻿using lms_backend.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace lms_backend.Controllers
{
    [Route("api/v1/teachers")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _service;

        public TeacherController(ITeacherService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult GetAllTeachers()
        {
            var teachers = _service.GetAllTeachers();

            if (teachers == null)
            {
                return NotFound("No Teachers Found!");
            }

            return Ok(teachers);
        }

        [HttpGet("{teacherid}")]
        public ActionResult GetTeacherById(int teacherid)
        {
            var teacher = _service.GetTeacherById(teacherid);

            if (teacher == null)
            {
                return NotFound($"Teacher with an id: {teacherid} not found");
            }

            return Ok(teacher);
        }

        [HttpGet("courses/{teacherId}")]
        public ActionResult GetAllCoursesByTeacher(int teacherId)
        {
            var courses = _service.GetAllCoursesByTeacher(teacherId);

            if (courses == null)
            {
                return NotFound($"Teacher with an id: {teacherId} has no available courses!");
            }

            return Ok(courses);
        }
    }
}
