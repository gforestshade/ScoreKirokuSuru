// このファイル内ではUnityの機能を使用していないのでusing不要
// 同様の理由でMonoBehaviorも継承しない
// using UnityEngine;

namespace ScoreKirokuSuru
{
    public struct SceneParams
    {
        public int Stage { get; set; }
        public int Score { get; set; }

        // これがポイント
        public static SceneParams Params = new SceneParams();
    }

    class Difficulties
    {
        private static readonly string[] strs = { "かんたん", "ふつう", "むずかしい" };
        public static string GetString(int diff) => strs[diff];
        public static string GetCurrentString() => GetString(SceneParams.Params.Stage);
    }

}
