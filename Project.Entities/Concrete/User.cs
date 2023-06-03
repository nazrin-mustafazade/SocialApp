﻿using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string User_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImagePath { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Addres { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Description { get; set; }


    }
}
