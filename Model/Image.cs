namespace Model
{
    public class Image
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Caption { get; set; }
        public string Route { get; set; }
        public string SubTitle { get; set; }
        public bool IsForBaseGallery { get; set; }
    }
}