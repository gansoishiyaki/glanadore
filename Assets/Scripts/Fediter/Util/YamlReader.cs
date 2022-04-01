using UnityEngine;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;
using System;

/// <summary>
/// Fediter
/// </summary>
namespace Fediter.Util
{
    /// <summary>
    /// YamlReader
    /// </summary>
    static public class YamlReader
    {
        /// <summary>
        /// YamlをObjectに変換
        /// </summary>
        /// <typeparam name="T">変換先クラス</typeparam>
        /// <param name="value">yamlの中身</param>
        /// <returns>変換結果</returns>
        static public T getYamlData<T>(string value)
        {
            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            return deserializer.Deserialize<T>(value);
        }

        /// <summary>
        /// リソースパスからオブジェクトを取得
        /// </summary>
        /// <typeparam name="T">変換先クラス</typeparam>
        /// <param name="path">ファイルパス</param>
        /// <returns>変換結果</returns>
        [Obsolete]
        static public T getYamlDataWithPath<T>(string path)
        {
            var input = Resources.Load(path) as TextAsset;
            return getYamlData<T>(input.text);
        }
    }
}