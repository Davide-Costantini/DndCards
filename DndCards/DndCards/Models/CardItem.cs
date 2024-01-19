namespace DndCards.Models
{
    public class CardItem
    {
        public static readonly string DefaultName = "Remira's Bulwark";
        public static readonly string DefaultBody = "<span style=\"font-size: small;\">When you assume a <span style=\"font-weight: bold;\">defensive</span> stance, you and all allies within 3m of you gain temporary hit points equal to your <span style=\"font-weight: bold;\">CHA</span> modifier</span><div><br></div><div><span style=\"font-size: small;\"><span style=\"font-style: italic;\">1/day, using this effect, you can restore the reaction of an ally, in case they have already spent it</span></span></div><div><span style=\"font-size: small;\"><span style=\"font-style: italic;\"><br></span></span></div><div><span style=\"font-size: small;\">\"A massive shield of iron and black wood that bears the symbol of the Remira Academy of Fine Arts. This shield is meant to represent unity and trust among all groups\"</span><span style=\"font-style: italic;\"><br></span></div>";
        public static readonly string DefaultType = "Shield";
        public static readonly string DefaultCharacteristics = "+2 CA";
        public static readonly string DefaultFooter = "Not for sale";
        public static readonly string DefaultImage = "/images/RemirasBulwark.jpg";

        public static readonly double DefaultCardHeightOverWidth = 1.37;
        public static readonly int DefaultCardWidth = 500;
        public static readonly int DefaultCardHeight = (int) (DefaultCardWidth * DefaultCardHeightOverWidth);
        public static readonly double DefaultCardOverImageDimensions = 0.93;

        public string Name { get; set; } = DefaultName;
        public string Body { get; set; } = DefaultBody;
        public bool RequiresAttunement { get; set; } = true;
        public string Type { get; set; } = DefaultType;
        public string Characteristics { get; set; } = DefaultCharacteristics;
        public string Footer { get; set; } = DefaultFooter;
        public string ImageUri { get; set; } = DefaultImage;
        public int CardWidth { get; set; } = DefaultCardWidth;
        public int CardHeight { get; set; } = DefaultCardHeight;
        public int ImageWidth { get; set; } = (int) (DefaultCardWidth * DefaultCardOverImageDimensions);
        public int ImageHeight { get; set; } = 465;
    }
}