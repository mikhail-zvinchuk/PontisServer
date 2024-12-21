using Pontis.GD_Legacy;

namespace Pontis;

public static class CardDatabase
{
    // Enums representing the kinds and types of cards
    public enum Kinds
    {
        Clubs,
        Diamond,
        Hearts,
        Spades
    }

    public enum Types
    {
        Regular,
        Joker,
        Joker_Red,
        Joker_Black
    }

    // Enum representing all the available cards in the database
    public enum Cards
    {
        Clubs_1, Clubs_2, Clubs_3, Clubs_4, Clubs_5, Clubs_6, Clubs_7, Clubs_8, Clubs_9, Clubs_10, Clubs_11, Clubs_12, Clubs_13,
        Diamond_1, Diamond_2, Diamond_3, Diamond_4, Diamond_5, Diamond_6, Diamond_7, Diamond_8, Diamond_9, Diamond_10, Diamond_11, Diamond_12, Diamond_13,
        Hearts_1, Hearts_2, Hearts_3, Hearts_4, Hearts_5, Hearts_6, Hearts_7, Hearts_8, Hearts_9, Hearts_10, Hearts_11, Hearts_12, Hearts_13,
        Spades_1, Spades_2, Spades_3, Spades_4, Spades_5, Spades_6, Spades_7, Spades_8, Spades_9, Spades_10, Spades_11, Spades_12, Spades_13,
        Joker_Red,
        Joker_Black,
        Joker
    }

    // Array of card back names
    public static readonly string[] CardBacks = {
        "Back_Blue_1",
        "Back_Blue_2",
        "Back_Grey_1",
        "Back_Grey_2",
        "Back_Red_1",
        "Back_Red_2"
    };

    // Dictionary containing the card data
    public static readonly Dictionary<Cards, CardData> DATA = new Dictionary<Cards, CardData>
    {
        { Cards.Clubs_1, new CardData(Types.Regular, 1, Kinds.Clubs, "Clubs_1") },
        { Cards.Clubs_2, new CardData(Types.Regular, 2, Kinds.Clubs, "Clubs_2") },
        { Cards.Clubs_3, new CardData(Types.Regular, 3, Kinds.Clubs, "Clubs_3") },
        { Cards.Clubs_4, new CardData(Types.Regular, 4, Kinds.Clubs, "Clubs_4") },
        { Cards.Clubs_5, new CardData(Types.Regular, 5, Kinds.Clubs, "Clubs_5") },
        { Cards.Clubs_6, new CardData(Types.Regular, 6, Kinds.Clubs, "Clubs_6") },
        { Cards.Clubs_7, new CardData(Types.Regular, 7, Kinds.Clubs, "Clubs_7") },
        { Cards.Clubs_8, new CardData(Types.Regular, 8, Kinds.Clubs, "Clubs_8") },
        { Cards.Clubs_9, new CardData(Types.Regular, 9, Kinds.Clubs, "Clubs_9") },
        { Cards.Clubs_10, new CardData(Types.Regular, 10, Kinds.Clubs, "Clubs_10") },
        { Cards.Clubs_11, new CardData(Types.Regular, 11, Kinds.Clubs, "Clubs_11") },
        { Cards.Clubs_12, new CardData(Types.Regular, 12, Kinds.Clubs, "Clubs_12") },
        { Cards.Clubs_13, new CardData(Types.Regular, 13, Kinds.Clubs, "Clubs_13") },

        { Cards.Diamond_1, new CardData(Types.Regular, 1, Kinds.Diamond, "Diamond_1") },
        { Cards.Diamond_2, new CardData(Types.Regular, 2, Kinds.Diamond, "Diamond_2") },
        { Cards.Diamond_3, new CardData(Types.Regular, 3, Kinds.Diamond, "Diamond_3") },
        { Cards.Diamond_4, new CardData(Types.Regular, 4, Kinds.Diamond, "Diamond_4") },
        { Cards.Diamond_5, new CardData(Types.Regular, 5, Kinds.Diamond, "Diamond_5") },
        { Cards.Diamond_6, new CardData(Types.Regular, 6, Kinds.Diamond, "Diamond_6") },
        { Cards.Diamond_7, new CardData(Types.Regular, 7, Kinds.Diamond, "Diamond_7") },
        { Cards.Diamond_8, new CardData(Types.Regular, 8, Kinds.Diamond, "Diamond_8") },
        { Cards.Diamond_9, new CardData(Types.Regular, 9, Kinds.Diamond, "Diamond_9") },
        { Cards.Diamond_10, new CardData(Types.Regular, 10, Kinds.Diamond, "Diamond_10") },
        { Cards.Diamond_11, new CardData(Types.Regular, 11, Kinds.Diamond, "Diamond_11") },
        { Cards.Diamond_12, new CardData(Types.Regular, 12, Kinds.Diamond, "Diamond_12") },
        { Cards.Diamond_13, new CardData(Types.Regular, 13, Kinds.Diamond, "Diamond_13") },

        { Cards.Hearts_1, new CardData(Types.Regular, 1, Kinds.Hearts, "Hearts_1") },
        { Cards.Hearts_2, new CardData(Types.Regular, 2, Kinds.Hearts, "Hearts_2") },
        { Cards.Hearts_3, new CardData(Types.Regular, 3, Kinds.Hearts, "Hearts_3") },
        { Cards.Hearts_4, new CardData(Types.Regular, 4, Kinds.Hearts, "Hearts_4") },
        { Cards.Hearts_5, new CardData(Types.Regular, 5, Kinds.Hearts, "Hearts_5") },
        { Cards.Hearts_6, new CardData(Types.Regular, 6, Kinds.Hearts, "Hearts_6") },
        { Cards.Hearts_7, new CardData(Types.Regular, 7, Kinds.Hearts, "Hearts_7") },
        { Cards.Hearts_8, new CardData(Types.Regular, 8, Kinds.Hearts, "Hearts_8") },
        { Cards.Hearts_9, new CardData(Types.Regular, 9, Kinds.Hearts, "Hearts_9") },
        { Cards.Hearts_10, new CardData(Types.Regular, 10, Kinds.Hearts, "Hearts_10") },
        { Cards.Hearts_11, new CardData(Types.Regular, 11, Kinds.Hearts, "Hearts_11") },
        { Cards.Hearts_12, new CardData(Types.Regular, 12, Kinds.Hearts, "Hearts_12") },
        { Cards.Hearts_13, new CardData(Types.Regular, 13, Kinds.Hearts, "Hearts_13") },

        { Cards.Spades_1, new CardData(Types.Regular, 1, Kinds.Spades, "Spades_1") },
        { Cards.Spades_2, new CardData(Types.Regular, 2, Kinds.Spades, "Spades_2") },
        { Cards.Spades_3, new CardData(Types.Regular, 3, Kinds.Spades, "Spades_3") },
        { Cards.Spades_4, new CardData(Types.Regular, 4, Kinds.Spades, "Spades_4") },
        { Cards.Spades_5, new CardData(Types.Regular, 5, Kinds.Spades, "Spades_5") },
        { Cards.Spades_6, new CardData(Types.Regular, 6, Kinds.Spades, "Spades_6") },
        { Cards.Spades_7, new CardData(Types.Regular, 7, Kinds.Spades, "Spades_7") },
        { Cards.Spades_8, new CardData(Types.Regular, 8, Kinds.Spades, "Spades_8") },
        { Cards.Spades_9, new CardData(Types.Regular, 9, Kinds.Spades, "Spades_9") },
        { Cards.Spades_10, new CardData(Types.Regular, 10, Kinds.Spades, "Spades_10") },
        { Cards.Spades_11, new CardData(Types.Regular, 11, Kinds.Spades, "Spades_11") },
        { Cards.Spades_12, new CardData(Types.Regular, 12, Kinds.Spades, "Spades_12") },
        { Cards.Spades_13, new CardData(Types.Regular, 13, Kinds.Spades, "Spades_13") },

        { Cards.Joker_Red, new CardData(Types.Joker_Red, null, null, "Joker_Red") },
        { Cards.Joker_Black, new CardData(Types.Joker_Black, null, null, "Joker_Black") },
        { Cards.Joker, new CardData(Types.Joker, null, null, "Joker") },
    };
}