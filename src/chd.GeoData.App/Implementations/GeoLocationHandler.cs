﻿using chd.GeoData.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chd.GeoData.App.Implementations
{
    public class GeoLocationHandler : IGeoLocationHandler
    {

        public async Task<Location> GetCurrentGeoLocation(CancellationToken cancellationToken)
        {

            var request = new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(10));
            try
            {
                var location = await Geolocation.Default.GetLocationAsync(request, cancellationToken);
                return location;
            }
            catch { }
            return new Location(47.259659, 11.400375, 580);
        }
    }
}
