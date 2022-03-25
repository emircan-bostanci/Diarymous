using Diarymous.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diarymous.Models
{
    public class LikeManager
    {
        public bool likeChecker(bool isLogin,Diary post,Account user)
        {
            if(isLogin == true && user.likedPosts.FirstOrDefault(u => u.id == post.id) == null)
            {
                return false;
            }
            return true;
        }
        public void like(bool isLiked,Context db,Diary post,Account user)
        {
            if(isLiked == false)
            {
                post.likeCount++;
                user.likedPosts.Add(post);
                db.SaveChanges();
            }
            
        }
    }
}
