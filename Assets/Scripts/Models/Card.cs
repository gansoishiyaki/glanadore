using System.Collections.Generic;
using System;

[Serializable]
public class Card
{
    public enum Attribute
    {
        union,
        passive,
        counter
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