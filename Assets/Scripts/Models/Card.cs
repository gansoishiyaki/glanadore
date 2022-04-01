using System.Collections.Generic;
using YamlDotNet.Serialization;

public class Card
{
    public enum Type
    {
        Passive,
        Equipe,
        Skill,
        Tool
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

    public List<Attribute> attributes;
    public Type type;

    // Deserialized
    [YamlMember(Alias ="type")]
    public string _type;
    [YamlMember(Alias = "attributes")]
    public List<string> _attributes;
}