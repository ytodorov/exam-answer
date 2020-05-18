using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_answerWeb.Infrastructure
{
    // https://adespresso.com/blog/google-ads-size/
    /*
250 x 250 – Square
200 x 200 – Small Square
468 x 60 – Banner
728 x 90 – Leaderboard
300 x 250 – Inline Rectangle
336 x 280 – Large Rectangle
120 x 600 – Skyscraper
160 x 600 – Wide Skyscraper
300 x 600 – Half-Page Ad
970 x 90 – Large Leaderboard
*/
    public enum AdsenseType
    {
        ResponsiveAdSquare,
        ResponsiveAdHorizontal,
        ResponsiveAdVertical,
        Fixed_300_600, // Half Page aka Large Skyscraper
        Fixed_336_280, // Large Rectangle 2 place
        Fixed_300_250, // Medium Rectangle 1 place
        Fixed_728_90, // Leader board 3 place
        Fixed_160_600, //Wide Skyscraper
        Fixed_970_90,
        Fixed_320_100,

    }
}
