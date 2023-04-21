using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetVersionChanges
{
    public class Phone
    {
        #region Auto Property
        //Not Auto Property:
        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int Model { get; set; }

        public const string SomeProperty = "Some Value";

        public string SomeAutoProp { get; } = SomeProperty;
        #endregion
    }
}
