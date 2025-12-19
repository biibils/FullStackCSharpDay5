using StudentMVC.Models;

namespace StudentMVC.Services;

public class AttendanceService : IAttendanceService
{
	private readonly List<Attendance> _attendance = new();

	public void CreateAttendance(Attendance attendance)
	{
		attendance.Id = _attendance.Count + 1;
		_attendance.Add(attendance);
	}

	public IEnumerable<Attendance> GetByStudent(int studentId)
	{
		return _attendance.Where(a => a.StudentId == studentId);
	}
}