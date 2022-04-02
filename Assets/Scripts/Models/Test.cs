using System;
using System.Collections.Generic;

[Serializable]
public class TestClass
{
    public List<Ele> eles;
}

[Serializable]
public class Ele
{
    public string name;
}