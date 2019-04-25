﻿using Sitecore.XA.Foundation.Variants.Abstractions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SF.Foundation.ViewVariants.Models
{
    public class GenericVariantModel : VariantsRenderingModel
    {
        public string ContainerClass { get; set; }
        public bool StickyAnchorLinkModule { get; set; }
    }
}