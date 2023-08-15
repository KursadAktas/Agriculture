﻿using System.ComponentModel.DataAnnotations;

namespace Agriculture.WebUI.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık Boş Geçilemez.")]
        public string Title { get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel Değeri Boş Geçilemez.")]
        public string Image { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama Boş Geçilemez.")]
        public string Description { get; set; }
    }
}
