using InfluxData.Net.Contracts;
using InfluxData.Net.Enums;
using InfluxData.Net.Infrastructure.Configuration;
using InfluxData.Net.Infrastructure.Formatters;

namespace InfluxData.Net.Client
{
    internal class InfluxDbClientV095 : InfluxDbClientBase
    {
        public InfluxDbClientV095(InfluxDbClientConfiguration configuration) 
            : base(configuration)
        {
        }

        public override IFormatter GetFormatter()
        {
            return new FormatterV095();
        }

        public override InfluxVersion GetVersion()
        {
            return InfluxVersion.v095;
        }
    }
}