using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgePractice
{
    public class Youtube_Repository
    {
        private List<YouTube> _listofVideos = new List<YouTube>();

        //Create
        public void AddVideosToYouTube(YouTube youtube)
        {
            _listofVideos.Add(youtube);
        }

        //Read
        public List<YouTube> DisplayYoutubeList()
        {
            return _listofVideos;
        }

        //Update
        public bool UpdateExisitingYouTube(string mainVideos, YouTube newVideo)
        {
            //Find the video
            YouTube oldContent = GetVideoByName(mainVideos);

           //update video
           if(oldContent != null)
            {
                oldContent.Name = newVideo.Name;
                oldContent.Channel = newVideo.Channel;
                oldContent.NumberOfLikes = newVideo.NumberOfLikes;
                oldContent.NumberOfViews = newVideo.NumberOfViews;
                oldContent.NumberOfDislikes = newVideo.NumberOfDislikes;
                oldContent.Uploaded = newVideo.Uploaded;
                oldContent.Comment = newVideo.Comment;
                oldContent.VideoTypes = newVideo.VideoTypes;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveVideosFromYoutube(string name)
        {
            YouTube youtube = GetVideoByName(name);

            if(youtube == null)
            {
                return false;
            }

            int initialCount = _listofVideos.Count;
            _listofVideos.Remove(youtube);

            if(initialCount > _listofVideos.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public YouTube GetVideoByName(string name)
        {
            foreach(YouTube youtube in _listofVideos)
            {
                if(youtube.Name.ToLower() == name.ToLower())
                {
                    return youtube;
                }
            }
            return null; 
        }
    }
}
