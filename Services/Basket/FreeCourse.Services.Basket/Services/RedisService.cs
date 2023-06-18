﻿using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Services.Basket.Services
{
    public class RedisService
    {
        private ConnectionMultiplexer _ConnectionMultiplexer;



        public void Connect(ConfigurationOptions options) => _ConnectionMultiplexer = ConnectionMultiplexer.Connect(options);

        public IDatabase GetDb(int db = 1) => _ConnectionMultiplexer.GetDatabase(db);
    }
}