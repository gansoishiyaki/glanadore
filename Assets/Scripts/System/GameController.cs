using UnityEngine;

/// <summary>
/// Game全体の管理用非コントローラー
/// シングルトン
/// </summary>
public class GameController
{
    // private
    private static GameController _gameController; // インスタンス

    /// <summary>
    /// コンストラクタ
    /// 外部から呼び出し不可
    /// </summary>
    private GameController()
    {
        // 初期化処理
        Screen.SetResolution(width: Const.GameMain.Witdh, height: Const.GameMain.Height, false, Const.GameMain.RefreshRate);
    }

    [RuntimeInitializeOnLoadMethod]
    static void OnRuntimeMethodLoad()
    {
        // 初期化処理
        _ = getInstance;
    }

    /// <summary>
    /// インスタンス取得
    /// </summary>
    public static GameController getInstance
    {
        get
        {
            if (_gameController == null)
            {
                _gameController = new GameController();
            }

            return _gameController;
        }
    }
}
