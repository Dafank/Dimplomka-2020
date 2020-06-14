using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Diplom.Shared.Entities
{
    public class Plant
    {
        public int Id { get; set; } = 1;
        [Required]
        public string Title { get; set; } //Назва
        public DateTime? WaterDate { get; set; }//Дата поливу
        public DateTime? FertiliDate { get; set; }//Дата удобрення
        public string Picture { get; set; } //Картинка рослини
        public string Note { set; get; }
    }
}
