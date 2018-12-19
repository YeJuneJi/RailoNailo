using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailoNailo
{

    class SearchKeyword
    {
        private string contentID;

        public string ContentID
        {
            get { return contentID; }
            set { contentID = value; }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string firstImage;
        public string FirstImage
        {
            get { return firstImage; }
            set { firstImage = value; }
        }
    }
}
