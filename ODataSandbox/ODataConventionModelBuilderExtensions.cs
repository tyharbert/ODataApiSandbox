using Microsoft.OData.ModelBuilder;

namespace ODataSandbox
{
    public static class ODataConventionModelBuilderExtensions
    {
        public static void AddEntitySetWithFullPermissions<TEntitySet>(this ODataConventionModelBuilder builder, string name) where TEntitySet : class
        {
            builder.EntitySet<TEntitySet>(name)
                .EntityType
                .Count()
                .Filter()
                .OrderBy()
                .Expand()
                .Select(); 
        }
    }
}