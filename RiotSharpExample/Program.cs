﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RiotSharp;

namespace RiotSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //toreplace
            var api = RiotApi.GetInstance(ConfigurationManager.AppSettings["ApiKey"], false);

            var summ = api.GetSummoner(Region.euw, 42091042);
            //var stats = summ.GetPlayerStatsRanked(Season.SEASON3);
            //foreach (var stat in stats)
            //{
            //    Console.WriteLine(stat.Id);
            //    Console.WriteLine(stat.Name);
            //    if (stat.Stats != null && stat.Stats.Count > 0)
            //    {
            //        foreach (var s in stat.Stats)
            //        {
            //            Console.WriteLine("    " + s.Count);
            //            Console.WriteLine("    " + s.Name);
            //            Console.WriteLine("    " + s.Id);
            //            Console.WriteLine("    " + s.Value);
            //            Console.WriteLine();
            //        }
            //    }
            //    Console.WriteLine();
            //}

            var stats = summ.GetStatsSummaries(Season.Season3);
            foreach (var stat in stats)
            {
                if (stat.AggregatedStats != null && stat.AggregatedStats.Count > 0)
                {
                    foreach (var aStat in stat.AggregatedStats)
                    {
                        Console.WriteLine("    " + aStat.Count);
                        Console.WriteLine("    " + aStat.Id);
                        Console.WriteLine("    " + aStat.Name);
                        Console.WriteLine();
                    }
                    Console.WriteLine(stat.Losses);
                    Console.WriteLine(stat.ModifyDate);
                    Console.WriteLine(stat.ModifyDateString);
                    Console.WriteLine(stat.PlayerStatSummaryType);
                    Console.WriteLine(stat.Wins);
                    Console.WriteLine();
                }
            }

            //var leagues = summ.GetLeagues();
            //foreach (League league in leagues)
            //{
            //    Console.WriteLine(league.Name);
            //    Console.WriteLine(league.Queue);
            //    Console.WriteLine(league.Tier);
            //    Console.WriteLine(league.Timestamp);
            //    foreach (LeagueItem entry in league.Entries)
            //    {
            //        Console.WriteLine("    " + entry.IsFreshBlood);
            //        Console.WriteLine("    " + entry.IsHotStreak);
            //        Console.WriteLine("    " + entry.IsInactive);
            //        Console.WriteLine("    " + entry.IsVeteran);
            //        Console.WriteLine("    " + entry.LastPlayed);
            //        Console.WriteLine("    " + entry.LeagueName);
            //        Console.WriteLine("    " + entry.LeaguePoints);
            //        Console.WriteLine("    " + entry.Losses);
            //        if (entry.MiniSeries != null)
            //        {
            //            Console.WriteLine("        " + entry.MiniSeries.Losses);
            //            Console.Write("        ");
            //            foreach (var c in entry.MiniSeries.Progress)
            //            {
            //                Console.Write(c);
            //            }
            //            Console.WriteLine();
            //            Console.WriteLine("        " + entry.MiniSeries.Target);
            //            Console.WriteLine("        " + entry.MiniSeries.TimeLeftToPlayMillis);
            //            Console.WriteLine("        " + entry.MiniSeries.Wins);
            //        }
            //        Console.WriteLine("    " + entry.PlayerOrTeamId);
            //        Console.WriteLine("    " + entry.PlayerOrTeamName);
            //        Console.WriteLine("    " + entry.QueueType);
            //        Console.WriteLine("    " + entry.Rank);
            //        Console.WriteLine("    " + entry.Tier);
            //        Console.WriteLine("    " + entry.TimeUntilDecay);
            //        Console.WriteLine("    " + entry.Wins);
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}

            //var games = summ.GetRecentGames();
            //foreach (Game game in games)
            //{
            //    Console.WriteLine(game.ChampionId);
            //    Console.WriteLine(game.CreateDate);
            //    Console.WriteLine(game.CreateDateString);
            //    foreach (var player in game.FellowPlayers)
            //    {
            //        Console.WriteLine("    " + player.ChampionId);
            //        Console.WriteLine("    " + player.SummonerId);
            //        Console.WriteLine("    " + player.TeamId);
            //    }
            //    Console.WriteLine(game.GameId);
            //    Console.WriteLine(game.GameMode);
            //    Console.WriteLine(game.GameType);
            //    Console.WriteLine(game.Invalid);
            //    Console.WriteLine(game.Level);
            //    Console.WriteLine(game.MapId);
            //    Console.WriteLine(game.Spell1);
            //    Console.WriteLine(game.Spell2);
            //    foreach (var stat in game.Statistics)
            //    {
            //        Console.WriteLine("    " + stat.Id);
            //        Console.WriteLine("    " + stat.Name);
            //        Console.WriteLine("    " + stat.Value);
            //    }
            //    Console.WriteLine(game.SubType);
            //    Console.WriteLine(game.TeamId);
            //    Console.WriteLine();
            //}

            //var champs = api.GetChampions(Region.euw);
            //foreach (Champion champ in champs)
            //{
            //    Console.WriteLine(champ.Active);
            //    Console.WriteLine(champ.AttackRank);
            //    Console.WriteLine(champ.BotEnabled);
            //    Console.WriteLine(champ.BotMmEnabled);
            //    Console.WriteLine(champ.DefenseRank);
            //    Console.WriteLine(champ.DifficultyRank);
            //    Console.WriteLine(champ.FreeToPlay);
            //    Console.WriteLine(champ.Id);
            //    Console.WriteLine(champ.MagicRank);
            //    Console.WriteLine(champ.Name);
            //    Console.WriteLine(champ.RankedPlayEnabled);
            //    Console.WriteLine();
            //}

            //var summoner = api.GetSummoners(Region.euw, new List<int> { 42091042 });

            //foreach (SummonerBase parent in summoner)
            //{
            //    Console.WriteLine(parent.Id);
            //    Console.WriteLine(parent.Name);
            //    Console.WriteLine();
            //}

            //var summ = api.GetSummoner(Region.euw, 42091042);
            //var masteries = summ.GetMasteryPages().First();

            //foreach (Talent talent in masteries.Talents)
            //{
            //    Console.WriteLine(talent.Name + " " + talent.Rank);
            //}

            //var pages = summ.GetRunePages();

            //foreach (RunePage page in pages.Take(100))
            //{
            //    if (page.Slots != null && page.Slots.Count > 0)
            //    {
            //        foreach (RuneSlot slot in page.Slots)
            //        {
            //            Console.WriteLine(slot.RuneSlotId);
            //            Console.WriteLine(slot.Rune.Description);
            //            Console.WriteLine(slot.Rune.Tier);
            //            Console.WriteLine(slot.Rune.Name);
            //            Console.WriteLine();
            //        }
            //    }
            //    Console.WriteLine(page.Name);
            //    Console.WriteLine();
            //}

            //Console.WriteLine(summoner.Name);
            //Console.WriteLine(summoner.Level);
            //Console.WriteLine(summoner.Id);
            //Console.WriteLine(summoner.ProfileIconId);
            //Console.WriteLine(summoner.RevisionDate);
            //Console.WriteLine(summoner.RevisionDateString);

            Console.ReadLine();
        }
    }
}