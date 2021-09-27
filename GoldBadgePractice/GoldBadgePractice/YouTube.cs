using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgePractice
{
    public enum TypesOfVideos
    {
        Comedy = 1,
        Basketball ,
        Documentary,
        Gaming,
        News

    }
    public class YouTube
    {
        public int NumberOfLikes { get; set; }
        public string Channel { get; set; }
        public string Name { get; set; }
        public int NumberOfViews { get; set; }
        public string Comment { get; set; }
        public int NumberOfDislikes { get; set; }
        public DateTimeOffset Uploaded { get; set; }
        public TypesOfVideos VideoTypes { get; set; }

        public YouTube() { }

        public YouTube(int numberoflikes, string channel, string name, int numberofviews, string comment, int numberofdislikes, DateTimeOffset upload, TypesOfVideos videos)
        {
            NumberOfLikes = numberoflikes;
            Channel = channel;
            Name = name;
            NumberOfViews = numberofviews;
            Comment = comment;
            NumberOfDislikes = numberoflikes;
            Uploaded = upload;
            VideoTypes = videos;

        }
    }

}
