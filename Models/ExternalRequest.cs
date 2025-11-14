namespace sprinklrGcs.Models
{
    public class ExternalRequest
    {
        public Filter Filter { get; set; }
        public Page Page { get; set; }
    }

    public class Filter
    {
        public string Type { get; set; }
        public List<FilterItem> Filters { get; set; }
    }

    public class FilterItem
    {
        public string Type { get; set; }
        public string Key { get; set; }
        public List<string> Values { get; set; }
    }

    public class Page
    {
        public int Size { get; set; }
    }
}
