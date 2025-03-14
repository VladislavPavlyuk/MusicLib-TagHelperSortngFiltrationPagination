﻿using System.ComponentModel.DataAnnotations;

namespace MusicLib.BLL.DTO
{
    // Data Transfer Object - специальная модель для передачи данных
    // Класс ArtistDTO должен содержать только те данные, которые нужно передать 
    // на уровень представления или, наоборот, получить с этого уровня.
    public class ArtistDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is requred!")]
        public string? Name { get; set; }

        [DataType(DataType.Date)]   
        public string? BirthDate { get; set; }
    }
}
