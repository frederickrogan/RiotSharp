﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiotSharp;
using RiotSharp.Misc;


namespace RiotSharp.Test
{
    [TestClass]
    public class StatusRiotApiTest : CommonTestBase
    {
        private static StatusRiotApi api = StatusRiotApi.GetInstance(apiKey);

        [TestMethod]
        [TestCategory("StatusRiotApi")]
        public void GetShardStatus_Test()
        {
            EnsureCredibility(() =>
            {
                var shardStatus = api.GetShardStatus(summoner1and2Region);

                Assert.AreEqual(StatusRiotApiTestBase.platform.ToString().ToLower(),
                    shardStatus.RegionTag);
            });
        }

        [TestMethod]
        [TestCategory("StatusRiotApi"), TestCategory("Async")]
        public void GetShardStatusAsync_Test()
        {
            EnsureCredibility(() =>
            {
                var shardStatus = api.GetShardStatusAsync(summoner1and2Region);

                Assert.AreEqual(StatusRiotApiTestBase.platform.ToString().ToLower(),
                    shardStatus.Result.RegionTag);
            });
        }
    }
}
