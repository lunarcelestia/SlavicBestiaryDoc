using System.ComponentModel.DataAnnotations;

namespace SlavicMyths.Models
{
    public class Phenomenon
    {
        public int Id { get; set; } // Уникальный идентификатор
        [Required]
        public string Name { get; set; } // Название феномена
        public string Description { get; set; } // Описание феномена
        public string ImageUrl { get; set; } // URL изображения (опционально)
        public int SectionId { get; set; } // Связь с разделом (внешний ключ)
        public Section Section { get; set; }  // Свойство навигации для раздела
        public string Type { get; set; }
    }
}