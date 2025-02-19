﻿using System.Collections.Generic;
using Amazon;
using Ninja.Utilities;

namespace Ninja.Models.AWS
{
    using Utilities;

    public class AWSRegion : SingletonBase<AWSRegion>
    {
        private readonly HashSet<string> _regions = new();

        public AWSRegion()
        {
            foreach (var region in RegionEndpoint.EnumerableAllRegions)
                _regions.Add(region.SystemName);
        }

        public bool RegionExists(string region)
        {
            return _regions.Contains(region);
        }
    }
}