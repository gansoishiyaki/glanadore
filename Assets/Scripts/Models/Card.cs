using System.Collections.Generic;
using System;

[Serializable]
public class Card
{
    public enum CardType
    {
        None,
        Union,
        Equipe,
        Skill,
        Item
    }

    public enum Attribute
    {
        Union
    }

    public string id;
    public string name;
    public string title;
    public string description;

    public int maxHP;
    public int interigence;
    public int str;
    public int spd;
    public int dex;
    public int luck;

    public string type;
    public List<string> attributes;

    /// <summary>
    /// カードタイプ
    /// </summary>
    public CardType Type
    {
        get
        {
            CardType res;
            return Enum.TryParse(type, out res) ? res : CardType.None;
        }
    }

    /// <summary>
    /// その属性を持っているか
    /// </summary>
    /// <param name="attribute"></param>
    /// <returns></returns>
    public bool HasAttribute(Attribute attribute)
    {
        return attributes.Contains(attribute.ToString());
    }
}

/// <summary>
/// Jsonシリアライズ用
/// </summary>
[Serializable]
public class CardSerializer
{
    public List<Card> cards;
}