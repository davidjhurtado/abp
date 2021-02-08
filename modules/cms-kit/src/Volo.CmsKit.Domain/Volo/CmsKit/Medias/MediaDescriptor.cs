﻿using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;
using Volo.CmsKit.Medias.Extensions;

namespace Volo.CmsKit.Medias
{
    public class MediaDescriptor : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; protected set; }
        
        public string Name { get; protected set; }

        public string MimeType { get; set; }

        public int Size { get; protected set; }

        protected MediaDescriptor()
        {
            
        }

        public MediaDescriptor(Guid id, Guid? tenantId, string name, string mimeType, int size) : base(id)
        {
            TenantId = tenantId;
            MimeType = mimeType;
            Size = size;
            
            SetName(name);
        }

        public void SetName(string name)
        {
            if (!name.IsValidMediaFileName())
            {
                throw new InvalidMediaDescriptorNameException(name);
            }

            Name = name;
        }
    }
}