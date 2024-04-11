namespace ComicApp.Domain.Entities
{
    public class Comic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public IList<ComicCharacter> ComicCharacters { get; set; }
    }
}
