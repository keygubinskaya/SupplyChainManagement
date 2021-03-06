﻿using System;

namespace TicketStore.Core
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyOrderAttribute : Attribute
    {
        public PropertyOrderAttribute(int order)
        {
            this.Order = order;
        }

        public int Order { get; set; }
    }
}