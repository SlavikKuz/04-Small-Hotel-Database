﻿using System;

namespace HotelDb.Logic.Entities
{
    public class RoomLL
    {
        public long Id { get; set; }
        public string RoomDescription { get; set; }
        public int NumberBeds { get; set; }
        public string Floor { get; set; }
        public string Info  { get; set; }
        
        //ready or not to accept guests, not - renowation, flood, etc
        public string Active { get; set; }

    }
}
