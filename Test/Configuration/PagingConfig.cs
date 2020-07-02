using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Configuration
{
    public class PagingConfig
    {
        public bool Enabled { get; set; }
        public int PageSize { get; set; }
        public bool CustomPager { get; set; }
        public int NumOfItemsToSkip(int pageNumber)
        {
            if (Enabled)
            {
                return (pageNumber - 1) * PageSize;
            }
            return 0;
        }
        public int NumOfItemsToTake(int totalItemsCount)
        {
            if (Enabled)
            {
                return PageSize;
            }
            return totalItemsCount;
        }
        public int PrevPageNumber(int curretPageNumber)
        {
            if (curretPageNumber > 1)
                return curretPageNumber - 1;
            else
                return 1;
        }
        public int NextPageNumber(int curretPageNumber, int totalItemsCount)
        {
            if (curretPageNumber<MaxPageNumber(totalItemsCount))
            {
                return curretPageNumber + 1;
            }
            else
            {
                return curretPageNumber;
            }
        }

        public int MaxPageNumber(int totalItemsCount)
        {
            int maxPageNumber;
            double numberOfPages = (double)totalItemsCount /(double) PageSize;
            if (numberOfPages == Math.Floor(numberOfPages))
                maxPageNumber = (int)numberOfPages;
            else
                maxPageNumber = (int)numberOfPages + 1;

            return maxPageNumber;
        }
    }
}
