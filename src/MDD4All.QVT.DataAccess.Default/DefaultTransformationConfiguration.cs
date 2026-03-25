using LL.MDE.Components.Qvt.Common.DataModels;

namespace MDD4All.QVT.DataAccess.Default
{
    public class DefaultTransformationConfiguration : ITransformationConfiguration
    {
        public IDomainJsonSerializer JsonSerializer { get; set; }

        public DefaultTransformationConfiguration()
        {
            JsonSerializer = new DefaultDomainJsonSerializer();
        }
    }
}
