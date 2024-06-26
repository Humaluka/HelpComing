﻿using System.ComponentModel.DataAnnotations;

namespace HelpComing.Models
{
    public class CreateRequestViewModel
    {
        public Guid RequestID { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string PersonName { get; set; }

        public IFormFile PhotoFile { get; set; }

        public byte[] Photo
        {
            get
            {
                if (PhotoFile != null)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        PhotoFile.CopyTo(memoryStream);
                        return memoryStream.ToArray();
                    }
                }
                return null;
            }
        }

        [Required(ErrorMessage = "Обязательное поле")]
        public string LastSeenLocation { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public DateTime LastSeenDateTime { get; set; }

        [Required(ErrorMessage = "Обязательное поле")]
        public string Description { get; set; }

        public Guid? CreateUser { get; set; }

        public string RequestDate { get; set; }
    }
}
