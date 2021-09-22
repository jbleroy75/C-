﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Exercice5
    {
        public static void StartExercice5()
        {
            using (StreamReader r = new StreamReader("/Users/jean-baptisteleroy/Desktop/TP1/ConsoleApplication1/DOGE_AllDataPoints_3Days.json"))
            {
                string json = r.ReadToEnd();
                Root JsonData = JsonConvert.DeserializeObject<Root>(json);
                
            }
        }
    }
    public class Config
    {
        public string data { get; set; }
        public int data_points { get; set; }
        public string interval { get; set; }
        public string symbol { get; set; }
    }

    public class Usage
    {
        public int day { get; set; }
        public int month { get; set; }
    }

    public class TimeSery
    {
        public int asset_id { get; set; }
        public int time { get; set; }
        public double open { get; set; }
        public double close { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double volume { get; set; }
        public object market_cap { get; set; }
        public int url_shares { get; set; }
        public int unique_url_shares { get; set; }
        public int reddit_posts { get; set; }
        public int reddit_posts_score { get; set; }
        public int reddit_comments { get; set; }
        public int reddit_comments_score { get; set; }
        public int tweets { get; set; }
        public int tweet_spam { get; set; }
        public int tweet_followers { get; set; }
        public int tweet_quotes { get; set; }
        public int tweet_retweets { get; set; }
        public int tweet_replies { get; set; }
        public int tweet_favorites { get; set; }
        public int tweet_sentiment1 { get; set; }
        public int tweet_sentiment2 { get; set; }
        public int tweet_sentiment3 { get; set; }
        public int tweet_sentiment4 { get; set; }
        public int tweet_sentiment5 { get; set; }
        public int tweet_sentiment_impact1 { get; set; }
        public int tweet_sentiment_impact2 { get; set; }
        public int tweet_sentiment_impact3 { get; set; }
        public int tweet_sentiment_impact4 { get; set; }
        public int tweet_sentiment_impact5 { get; set; }
        public int social_score { get; set; }
        public double average_sentiment { get; set; }
        public int sentiment_absolute { get; set; }
        public int sentiment_relative { get; set; }
        public int news { get; set; }
        public double price_score { get; set; }
        public double social_impact_score { get; set; }
        public double correlation_rank { get; set; }
        public double galaxy_score { get; set; }
        public double volatility { get; set; }
        public int alt_rank { get; set; }
        public int alt_rank_30d { get; set; }
        public double alt_rank_hour_average { get; set; }
        public int market_cap_rank { get; set; }
        public int percent_change_24h_rank { get; set; }
        public int volume_24h_rank { get; set; }
        public int social_volume_24h_rank { get; set; }
        public int social_score_24h_rank { get; set; }
        public int social_contributors { get; set; }
        public int social_volume { get; set; }
        public double price_btc { get; set; }
        public int social_volume_global { get; set; }
        public double social_dominance { get; set; }
        public object market_cap_global { get; set; }
        public double market_dominance { get; set; }
        public double percent_change_24h { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
        public double price { get; set; }
        public double price_btc { get; set; }
        public long market_cap { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_7d { get; set; }
        public double percent_change_30d { get; set; }
        public double volume_24h { get; set; }
        public int social_contributors_calc_24h_previous { get; set; }
        public int url_shares_calc_24h_previous { get; set; }
        public int tweet_spam_calc_24h_previous { get; set; }
        public int news_calc_24h_previous { get; set; }
        public double average_sentiment_calc_24h_previous { get; set; }
        public int social_score_calc_24h_previous { get; set; }
        public int social_volume_calc_24h_previous { get; set; }
        public int alt_rank_30d_calc_24h_previous { get; set; }
        public int alt_rank_calc_24h_previous { get; set; }
        public int social_contributors_calc_24h { get; set; }
        public double social_contributors_calc_24h_percent { get; set; }
        public int url_shares_calc_24h { get; set; }
        public double url_shares_calc_24h_percent { get; set; }
        public int tweet_spam_calc_24h { get; set; }
        public double tweet_spam_calc_24h_percent { get; set; }
        public int news_calc_24h { get; set; }
        public double news_calc_24h_percent { get; set; }
        public double average_sentiment_calc_24h { get; set; }
        public double average_sentiment_calc_24h_percent { get; set; }
        public int social_score_calc_24h { get; set; }
        public double social_score_calc_24h_percent { get; set; }
        public int social_volume_calc_24h { get; set; }
        public double social_volume_calc_24h_percent { get; set; }
        public int asset_id { get; set; }
        public int time { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double volume { get; set; }
        public int url_shares { get; set; }
        public int unique_url_shares { get; set; }
        public int reddit_posts { get; set; }
        public int reddit_posts_score { get; set; }
        public int reddit_comments { get; set; }
        public int reddit_comments_score { get; set; }
        public int tweets { get; set; }
        public int tweet_spam { get; set; }
        public int tweet_followers { get; set; }
        public int tweet_quotes { get; set; }
        public int tweet_retweets { get; set; }
        public int tweet_replies { get; set; }
        public int tweet_favorites { get; set; }
        public int tweet_sentiment1 { get; set; }
        public int tweet_sentiment2 { get; set; }
        public int tweet_sentiment3 { get; set; }
        public int tweet_sentiment4 { get; set; }
        public int tweet_sentiment5 { get; set; }
        public int tweet_sentiment_impact1 { get; set; }
        public int tweet_sentiment_impact2 { get; set; }
        public int tweet_sentiment_impact3 { get; set; }
        public int tweet_sentiment_impact4 { get; set; }
        public int tweet_sentiment_impact5 { get; set; }
        public int social_score { get; set; }
        public double average_sentiment { get; set; }
        public int sentiment_absolute { get; set; }
        public int sentiment_relative { get; set; }
        public int news { get; set; }
        public double price_score { get; set; }
        public double social_impact_score { get; set; }
        public double correlation_rank { get; set; }
        public double galaxy_score { get; set; }
        public double volatility { get; set; }
        public int alt_rank { get; set; }
        public int alt_rank_30d { get; set; }
        public double alt_rank_hour_average { get; set; }
        public int market_cap_rank { get; set; }
        public int percent_change_24h_rank { get; set; }
        public int volume_24h_rank { get; set; }
        public int social_volume_24h_rank { get; set; }
        public int social_score_24h_rank { get; set; }
        public int social_contributors { get; set; }
        public int social_volume { get; set; }
        public int social_volume_global { get; set; }
        public double social_dominance { get; set; }
        public long market_cap_global { get; set; }
        public double market_dominance { get; set; }
        public string tags { get; set; }
        public double close { get; set; }
        public List<TimeSery> timeSeries { get; set; }
    }

    public class Root
    {
        public Config config { get; set; }
        public Usage usage { get; set; }
        public List<Datum> data { get; set; }
    }


}