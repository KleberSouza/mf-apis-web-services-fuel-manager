namespace mf_apis_web_services_fuel_manager.Models
{
    public class LinkDto
    {
        public int Id { get; set; }
        public string Href { get; set; }
        public string Rel { get; set; }
        public string Metodo { get; set; }

        public LinkDto(int id, string href, string rel, string metodo)
        {
            Id = id;
            Href = href;
            Rel = rel;
            Metodo = metodo;
        }
    }

    public class LinksHATEOS
    {
        public List<LinkDto> Links { get; set; } = new List<LinkDto>();
    }
}
