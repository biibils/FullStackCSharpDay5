using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;
using StudentMVC.Services;

namespace StudentMVC.Controllers;

public class AttendanceController : Controller
{
	private readonly IStudentService _studentService;
	private readonly IAttendanceService _attendanceService;
	
	public AttendanceController(IStudentService studentService, IAttendanceService attendanceService)
	{
		_studentService = studentService;
		_attendanceService = attendanceService;
	}

	public IActionResult Create(int studentId)
	{
		var student = _studentService.GetStudentById(studentId);
		if (student == null) return NotFound();

		var model = new Attendance
		{
			StudentId = studentId,
			Student = student,
			Date = DateTime.Today,
			Time = DateTime.Now.TimeOfDay
		};

		return View(model);
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public IActionResult Create(Attendance attendance)
	{
		if (!ModelState.IsValid)
		{
			return View(attendance);
		}

		_attendanceService.CreateAttendance(attendance);
		return RedirectToAction("Index", "Student");
	}
}