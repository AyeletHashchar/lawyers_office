using System;
using System.Collections.Generic;

#nullable disable

namespace Dal.models
{
    public partial class Asset
    {
        public Asset()
        {
            Bags = new HashSet<Bag>();
        }

        public int Id { get; set; }
        public string BlockOrBook { get; set; }
        public string PlotOrPage { get; set; }
        public string SubPlot { get; set; }
        public string AssetAddress { get; set; }
        public string TikMinhal { get; set; }
        public string OtherDetails { get; set; }

        public virtual ICollection<Bag> Bags { get; set; }
    }
}
