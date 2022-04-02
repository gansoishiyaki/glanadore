using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// カードを管理するクラス
/// </summary>
public class CardController
{
    /// <summary>
    /// カードリスト
    /// </summary>
    public Dictionary<CardNum, Card> cards;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    [Obsolete]
    public CardController()
    {
        cards = SetCards();
        Debug.Log($"Success Load Card: {cards.Count} Count");
    }

    [Obsolete]
    private Dictionary<CardNum, Card> SetCards()
    {
        var json = Resources.Load("Data/cards") as TextAsset;
        var cardSerializer = JsonUtility.FromJson<CardSerializer>(json.text);

        return cardSerializer.cards.ToDictionary(card => (CardNum)Enum.Parse(typeof(CardNum), card.id));
    }
}
