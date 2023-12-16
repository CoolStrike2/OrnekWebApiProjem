﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage ="Servis ikon linki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Servis hizmet başlığı giriniz")]
        [StringLength(100,ErrorMessage ="Hizmet başlığı en fazla 100 karakter olabilir.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
