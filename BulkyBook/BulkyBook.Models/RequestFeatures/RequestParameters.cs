using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.Models.RequestFeatures
{
    public abstract class RequestParameters
    {
        const int maxPageSize = 8;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 4;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
