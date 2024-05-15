﻿using _01.celilcavus.Entity;
using _02.celilcavus.DbContexts;
using _03.celilcavus.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.celilcavus.Models.Repository
{
    public class PostsRepository : BaseRepository<Posts>, IPostsServices
    {
        public PostsRepository(BilimzamaniContext bilimzamaniContext) : base(bilimzamaniContext)
        {
        }
    }
}
