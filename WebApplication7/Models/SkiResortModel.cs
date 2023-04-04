using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class SkiResortModel
    {
        public int Id { get; set; }

        [DisplayName("Название курорта")]
        public string Name { get; set; }

        [DisplayName("Город")]
        public string City { get; set; }

        [DisplayName("Дата открытия")]
        [DataType(DataType.Date)]
        public DateTime OpenDate { get; set; }

        [DisplayName("Количество горнолыжных трасс")]
        public int NumberOfSkiSlopes { get; set; }

        [DisplayName("Средняя длина трассы")]
        public double AverageSlopeLength { get; set; }

        [DisplayName("Ежегодный общий доход")]
        public decimal AnnualRevenue { get; set; }
    }
}