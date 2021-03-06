﻿// Copyright (c) 2017 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using Newtonsoft.Json;
using System;

namespace TrakHound.Api.v2.Data
{
    public class Status
    {
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("timestamp")]
        [JsonConverter(typeof(Json.UnixTimeConverter))]
        public DateTime Timestamp { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("connected")]
        public bool Connected { get; set; }
    }
}
