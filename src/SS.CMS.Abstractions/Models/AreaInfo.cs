using SS.CMS.Data;

namespace SS.CMS.Abstractions.Models
{
    [Table("siteserver_Area")]
    public class AreaInfo : Entity
    {
        [TableColumn]
        public string AreaName { get; set; }

        [TableColumn]
        public int ParentId { get; set; }

        [TableColumn]
        public string ParentsPath { get; set; }

        [TableColumn]
        public int ParentsCount { get; set; }

        [TableColumn]
        public int ChildrenCount { get; set; }

        [TableColumn]
        public bool LastNode { get; set; }

        [TableColumn]
        public int Taxis { get; set; }
    }
}