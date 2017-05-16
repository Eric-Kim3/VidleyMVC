using System;
using System.ComponentModel.DataAnnotations;

namespace VidleyMVC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime? Birthday { get; set; }

        [Required]//making it not nullable
        [StringLength(255)] //String Length cannot be more than 255 
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        //navigation type
        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }



    }
}