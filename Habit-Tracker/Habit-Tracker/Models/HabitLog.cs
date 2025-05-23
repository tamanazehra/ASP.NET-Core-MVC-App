using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace HabitTracker.Models
{
    public class HabitLog
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        //  Foreign key (link to Habit)
        public int HabitId { get; set; }

        public Habit Habit { get; set; }
    }
}

