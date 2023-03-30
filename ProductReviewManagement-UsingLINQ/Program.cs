﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement_UsingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductReviewModel> listOfProductReview = new List<ProductReviewModel>()
            {
                new ProductReviewModel { ProductId = 1 , UserId = 11 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 2 , UserId = 10 , Rating = 2 , Review = "Bad" , isLike = false  },
                new ProductReviewModel { ProductId = 3 , UserId = 11 , Rating = 4 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 4 , UserId = 11 , Rating = 1 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 5 , UserId = 11 , Rating = 3 , Review = "Average" , isLike = true  },
                new ProductReviewModel { ProductId = 6 , UserId = 10 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 7 , UserId = 10 , Rating = 2 , Review = "Bad" , isLike = false  },
                new ProductReviewModel { ProductId = 8 , UserId = 8 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 9 , UserId = 11 , Rating = 1 , Review = "Bad" , isLike = false  },
                new ProductReviewModel { ProductId = 10 , UserId = 9 , Rating = 5 , Review = "Good" , isLike = true  },
                new ProductReviewModel { ProductId = 11 , UserId = 10 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 12 , UserId = 10 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 13 , UserId = 10 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 11 , UserId = 7 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 11 , UserId = 6 , Rating = 1 , Review = "Bad", isLike = false  },
                new ProductReviewModel { ProductId = 11 , UserId = 5 , Rating = 1 , Review = "Bad", isLike = false  },
            };
        }
    }
}
