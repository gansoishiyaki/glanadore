using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// カードを管理するクラス
/// </summary>
public class CardManager
{
    /// <summary>
    /// カードリスト
    /// </summary>
    public Dictionary<CardNum, Card> cards;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    [Obsolete]
    public CardManager()
    {
        cards = SetCards();
        Debug.Log($"Success Read Card: {cards.Count}Types");
    }

    [Obsolete]
    private Dictionary<CardNum, Card> SetCards()
    {
        var json = Resources.Load("Data/cards") as TextAsset;
        var cardSerializer = JsonUtility.FromJson<CardSerializer>(json.text);

        return cardSerializer.cards.ToDictionary(card => (CardNum)Enum.Parse(typeof(CardNum), card.id));
    }
}
