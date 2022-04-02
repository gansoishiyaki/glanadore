using System.Collections.Generic;
using System;

[Serializable]
public class Card
{
    public enum Type
    {
        Passive,
        Equipe,
        Skill,
        Tool,
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

    public string _type;
    public List<string> attributes;

    public Type type => (Type)Enum.Parse(typeof(Type), _type);

    public bool HasAttribute(Attribute attribute)
    {
        return attributes.Contains(attribute.ToString());
    }
}

[Serializable]
public class CardSerializer
{
    public List<Card> cards;
}