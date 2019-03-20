using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AuditDemo.Localization
{
    public static class AuditDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AuditDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AuditDemoLocalizationConfigurer).GetAssembly(),
                        "AuditDemo.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
