using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace National_Park_Blog.Models
{
    public class Blog_Content
    {
        public string BlogContentName { get; set; }
        public int Id { get; set; }
        public string BlogContentText { get; set; }
        public string BlogAuthor { get; set; }
        public DateTime BlogContentDate { get; set; }

        public int NationalParkId {get; set;}
        public virtual National_Parks NationalPark { get; set; }

        public Blog_Content()
        {

        }
        public Blog_Content(string blogContentName, string blogAuthor, int blogContentId, string blogContentText, DateTime blogContentDate, int nationalParkId)
        {
            BlogContentName = blogContentName;
            BlogAuthor = blogAuthor;
            Id = blogContentId;
            BlogContentText = blogContentText;
            BlogContentDate = blogContentDate;
            NationalParkId = nationalParkId;
        }
    }

}
