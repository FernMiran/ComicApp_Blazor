namespace ComicApp.Domain.Entities
{
    public class ComicCharacter
    {
        public int ComicId { get; set; }
        public int CharacterId { get; set; }

        public Comic Comic { get; set; }
        public Character Character { get; set; }
    }
}
