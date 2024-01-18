namespace DndCards.Models
{
    public class CardItem
    {
        public string Name { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public bool RequiresAttunement { get; set; } = false;
        public string Type { get; set; } = string.Empty;
        public string Characteristics { get; set; } = string.Empty;
        public string Footer { get; set; } = string.Empty;
        public string ImageUri { get; set; } = string.Empty;
        public int ImageWidth { get; set; } = 300;
        public int ImageHeight { get; set; } = 500;
    }
}