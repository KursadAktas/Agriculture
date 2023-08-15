using System.ComponentModel.DataAnnotations;

namespace Agriculture.WebUI.Models
{
	public class RegisterViewModel
	{
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz.")]
        public string userName { get; set; }

		[Required(ErrorMessage = "Lütfen Mail Giriniz.")]
		public string mail { get; set; }

		[Required(ErrorMessage = "Lütfen Şifre Giriniz.")]
		[Compare("password",ErrorMessage ="Şifreler Uyumlu Değil")]
		public string password { get; set; }

		[Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz.")]
		public string passwordConfirm { get; set; }

	}
}
