using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;

namespace AppointmentReminders.Web.Models
{
    public class Appointment
    {
        public static int ReminderTime = 1;
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Phone, Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Phone number cannot contain letters or symbols")]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public string Timezone { get; set; }

        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }
    }
}