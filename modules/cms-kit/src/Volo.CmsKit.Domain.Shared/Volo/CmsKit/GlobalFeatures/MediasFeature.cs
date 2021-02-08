﻿using JetBrains.Annotations;
using Volo.Abp.GlobalFeatures;

namespace Volo.CmsKit.GlobalFeatures
{
    [GlobalFeatureName(Name)]
    public class MediasFeature : GlobalFeature
    {
        public const string Name = "CmsKit.Medias";
        
        internal MediasFeature(
            [NotNull] GlobalCmsKitFeatures cmsKit
        ) : base(cmsKit)
        {
            
        }
    }
}