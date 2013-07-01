using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBox.Domain.Repositories;

namespace WebBox.Domain.Helpers
{
    public class SearchHelper
    {
        //public static IQueryable<UserLink> SearchFunction(string term)
        public static List<UserLink> SearchFunction(string term)
        {
            var _userLinkRepo = new Repository<UserLink>();
            //IQueryable<UserLink> userLinksResult = new List<UserLink>() as IQueryable<UserLink>;
            List<UserLink> userLinksResult = new List<UserLink>();

            if (!String.IsNullOrWhiteSpace(term))
            {
                if (term == "*")
                {
                    userLinksResult = _userLinkRepo.FindAll()
                                                    .OrderByDescending(r => r.LinkRating).ToList();
                }
                else
                {
                    userLinksResult = _userLinkRepo.FindAll(n => n.Title.ToLower()
                                                    .Contains(term.ToLower()))
                                                    .OrderByDescending(r => r.LinkRating).ToList();
                }
            }
            return userLinksResult;
        }
    }
}
