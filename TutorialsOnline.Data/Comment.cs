﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialsOnline.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int TutorId { get; set; }
        public Guid UserId { get; set; }
        public string Question { get; set; }
        public DateTimeOffset CreatedUTC { get; set; }
        public DateTimeOffset ModifiedUTC { get; set; }
    }
}
