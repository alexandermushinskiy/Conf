using System;
using Conf.Management.Extensibility.Providers;

namespace Conf.Management.Providers
{
    internal class GuidProvider : IGuidProvider
    {
        public Guid GetGuid()
        {
            return Guid.NewGuid();
        }
    }
}