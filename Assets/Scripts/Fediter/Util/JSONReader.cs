using UnityEngine;
using System;


/// <summary>
/// Fediter
/// </summary>
namespace Feditor.Util
{
    /// <summary>
    /// YamlReader
    /// </summary>
    static public class JsonReader
    {
        /// <summary>
        /// jsonを取得する
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        [Obsolete]
        static private JSONClass getJsonData(string path)
        {
            var json = Resources.Load(path) as TextAsset;
            return (JSONClass)JsonUtility.FromJson(json.text, typeof(JSONClass));
        }
    }
}