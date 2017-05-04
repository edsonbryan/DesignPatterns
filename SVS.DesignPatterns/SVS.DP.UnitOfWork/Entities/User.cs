﻿using System;

namespace SVS.DP.UnitOfWork.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public bool IsValid()
        {
            if (Id == 0)
                throw new Exception("User id should not be null");

            if (string.IsNullOrEmpty(Name))
                throw new Exception("User name must be provided");

            return true;
        }
    }
}
