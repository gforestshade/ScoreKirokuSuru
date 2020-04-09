using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.SceneManagement.SceneManager;

namespace ScoreKirokuSuru
{
    public class GameController : MonoBehaviour
    {
        [SerializeField]
        Text _DifficultyView = default;

        [SerializeField]
        InputField _InputField = default;

        private void Start()
        {
            _DifficultyView.text = Difficulties.GetCurrentString();
        }

        public void EndGame()
        {
            // 簡単のため自由入力にしているので
            // ここでテキストを整数に変換する
            if (!int.TryParse(_InputField.text, out int score)) return;

            // スコアをセットしてシーンを変える
            SceneParams.Params.Score = score;
            LoadScene("Result");
        }
    }
}
