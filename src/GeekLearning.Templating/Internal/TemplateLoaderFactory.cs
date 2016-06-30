﻿namespace GeekLearning.Templating.Internal
{
    using Storage;
    using Microsoft.Extensions.Caching.Memory;
    using System.Collections.Generic;

    public class TemplateLoaderFactory : ITemplateLoaderFactory
    {
        private IMemoryCache memoryCache;
        private readonly IEnumerable<ITemplateProvider> providers;

        public TemplateLoaderFactory(IEnumerable<ITemplateProvider> providers, IMemoryCache memoryCache)
        {
            this.providers = providers;
            this.memoryCache = memoryCache;
        }

        public ITemplateLoader Create(IStore store)
        {
            return new TemplateLoader(store, providers, memoryCache);
        }
    }
}