using System;
using System.ComponentModel.DataAnnotations;
using VidleyMVC.Models;

namespace VidleyMVC.Dtos
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.!.!.")]//making it not nullable
        [StringLength(255)] //String Length cannot be more than 255 
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}