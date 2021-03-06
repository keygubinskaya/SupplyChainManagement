﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using SCM.DataService.DataContext;
using SCM.DataService;

namespace SCM.Core
{
    [DebuggerDisplay("{TypeName,nq}={Id,nq}")]
    public class Entity : IEntityEvent, ICloneable
    {
        public Entity()
        {
            this.Title = string.Empty;
        }

        public int Id { get; set; }

        [DisplayName("Запрещено удалять")]
        public bool DeleteForbidden { get; set; }

        [DisplayName("Запрещено редактировать")]
        public bool EditForbidden { get; set; }

        [DisplayName("Название")]
        [DefaultValue("")]
        public string Title { get; set; }


        [DisplayName("Публиковать")]
        public bool IsPublish { get; set; }

        public DateTime? LastModifed { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public virtual string TypeName
        {
            get
            {
                return ObjectContext.GetObjectType(this.GetType()).Name;
            }
        }

        public virtual void Added(AppDataContext context)
        {
            
        }

        public virtual void Adding(AppDataContext context)
        {
            LastModifed = DateTime.Now;
        }

        public virtual void Deleting(AppDataContext context)
        {

        }

        public virtual void Deleted(AppDataContext context)
        {

        }

        public virtual void Updating(AppDataContext context)
        {
            LastModifed = DateTime.Now;
        }

        public virtual void Updated(AppDataContext context)
        {

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}