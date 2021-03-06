﻿namespace GeekLearning.Templating.BasicSample
{
    using Storage;
    using System.Threading.Tasks;

    public class EmailTemplates : TemplateCollectionBase
    {
        public EmailTemplates(IStorageFactory storageFactory, ITemplateLoaderFactory templateLoaderFactory) : base("Templates", storageFactory, templateLoaderFactory)
        {
        }

        public Task<string> ApplyInvitationTemplate(InvitationContext context)
        {
            return this.LoadAndApplyTemplate("invitation", context);
        }

        public Task<string> ApplyInvitation2Template(InvitationContext context)
        {
            return this.LoadAndApplyTemplate("invitation2", context);
        }

        public Task<string> ApplyInvitation3Template(InvitationContext context)
        {
            return this.LoadAndApplyTemplate("SubDir/invitation", context);
        }
    }
}
