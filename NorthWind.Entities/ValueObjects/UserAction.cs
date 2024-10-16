﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.ValueObjects
{
    public class UserAction(string user, string description)

    {
        private readonly DateTime createdDateTime = DateTime.Now;

        public DateTime GetCreatedDateTime()
        {
            return createdDateTime;
        }

        public DateTime CreatedDateTime { get; } = DateTime.Now;
        public string User => user;
        public string Description => description;
    }