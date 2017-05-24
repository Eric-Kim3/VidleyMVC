using System.Collections.Generic;

namespace VidleyMVC.Dtos
{
    public class NewRentalDTO
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }

    }
}