﻿using Bitstamp.Net.Http.Formatting;
using Newtonsoft.Json;
using System;

namespace Bitstamp.Models {
    public class Order {
        [JsonProperty("id")]
        public long OrderId { get; set; }
        
        [JsonProperty("order_type")]
        public int Type { get; set; }
        
        [JsonProperty("price")]
        [JsonConverter(typeof(DoubleConverter))]
        public double Price { get; set; }

        [JsonProperty("datetime")]
        [JsonConverter(typeof(DateTimeOffsetConverter))]
        public DateTimeOffset Datetime { get; set; }

        [JsonProperty("amount")]
        [JsonConverter(typeof(DoubleConverter))]
        public double Amount { get; set; }

        public override string ToString() {
            return (new { Datetime, OrderId, Type, Price, Amount }).ToString();
        }
    }
}

//{
//  "order_type": 0,
//  "price": "123.87",
//  "datetime": "1380234521",
//  "amount": "3.70000000",
//  "amount_sum": "22.20000000",
//  "id": 7629424
//}