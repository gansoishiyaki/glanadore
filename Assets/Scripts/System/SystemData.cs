using System;

/// <summary>
/// カードなど、参照したいシステムデータが格納されている
/// </summary>
public class SystemData
{
    /// <summary>
    /// カード管理クラス
    /// </summary>
    public CardManager cardManager;

    /// <summary>
    /// イニシャライズ
    /// データの初期設定など
    /// </summary>
    [Obsolete]
    public SystemData()
    {
        cardManager = new CardManager();
    }
}