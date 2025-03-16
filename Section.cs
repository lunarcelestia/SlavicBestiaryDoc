using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SlavicMyths.Models
{
    public class Section
    {
        public int Id { get; set; } // Уникальный идентификатор
        [Required]
        public string Name { get; set; } // Название раздела (например, "Боги", "Духи", "Существа")
        public string Description { get; set; } // Описание раздела (опционально)
        public List<Phenomenon> Phenomena { get; set; } // Свойство навигации для феноменов
    }
}