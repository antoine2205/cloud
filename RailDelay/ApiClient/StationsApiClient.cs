using CoreApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiClient
{
    public partial class ApiClient<T>
    {
        public async Task<List<T>>GetStrainStations()
        {
            Uri requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "/stations"));
            return await GetAsync<List<T>>(requestUrl);
        }
    }
}
