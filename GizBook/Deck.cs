public class Deck
{
    public string Title { get; set; }
    public int CardCount { get; set; }
    public Color DeckColor { get; set; }

    public Deck(string title, int cardCount, Color deckColor)
    {
        Title = title;
        CardCount = cardCount;
        DeckColor = deckColor;
    }
}