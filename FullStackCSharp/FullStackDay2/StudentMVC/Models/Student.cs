using System.ComponentModel.DataAnnotations;

namespace StudentMVC.Models;

public class Student
{
		[Key]
		public int Id { get; set; }
		
		[Required(ErrorMessage = "Nama harus diisi.")]
		[StringLength(100, ErrorMessage = "Nama tidak boleh lebih dari 100 karakter.")]
		public required string Name { get; set; }

		[Required(ErrorMessage = "Email harus diisi")]
		[EmailAddress(ErrorMessage = "Format email tidak valid.")]
		public required string Email { get; set; }

		[Range(18, 60, ErrorMessage = "Usia antara 18 hingga 60 tahun")]
		public int Age { get; set; }
}