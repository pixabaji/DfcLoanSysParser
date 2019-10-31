﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace JsonParseApp.Models
{
    [JsonObject("liabilities")]
    public class Liability
    {
        [JsonProperty("individual_financials.amount")]
        public string IndividualFinancialsAmount { get; set; }

        [JsonProperty("individual_financials.description")]
        public string IndividualFinancialsDescription { get; set; }
    }
}