using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

[System.Serializable]
public class CardData
{
    public string cardName;
    public int attack;
    public int defense;
    public int level;
    [JsonConverter(typeof(StringEnumConverter))]   
    public CardType type;
    public string artworkPath;
}
