﻿using System;
using System.Runtime.Serialization;

using BetterCms.Module.Api.Infrastructure;

using ServiceStack.ServiceHost;

namespace BetterCms.Module.Api.Operations.Pages.Sitemap.Tree
{
    [Obsolete("Use everything from BetterCms.Module.Api.Operations.Pages.Sitemaps name space.")]
    [Route("/sitemap-tree/{SitemapId}", Verbs = "GET")]
    [DataContract]
    public class GetSitemapTreeRequest : RequestBase<GetSitemapTreeModel>, IReturn<GetSitemapTreeResponse>
    {
        [DataMember]
        public System.Guid SitemapId { get; set; }
    }
}