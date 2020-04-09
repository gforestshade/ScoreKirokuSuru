using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.SceneManagement.SceneManager;

namespace ScoreKirokuSuru
{
    public class ResultController : MonoBehaviour
    {

        [SerializeField]
        Text _DifficultyView = default;

        [SerializeField]
        Text _ScoreView = default;

        [SerializeField]
        Text _HighScoreView = default;

        private void Start()
        {
            // ステージ番号とスコアを受け取る
            int stage = SceneParams.Params.Stage;
            int score = SceneParams.Params.Score;

            // 難易度表示
            _DifficultyView.text = Difficulties.GetString(stage);

            // "highscore_0","highscore_1"のような文字列を作り、
            // その文字列をもとにしてハイスコアを取得
            string highScoreKey = "highscore_" + stage;
            int currentHighScore = PlayerPrefs.GetInt(highScoreKey, 0);

            // スコア表示
            _ScoreView.text = score.ToString();

            // ハイスコアだったならその旨表示してPlayerPrefsも更新
            if (currentHighScore < score) 
            {
                _HighScoreView.gameObject.SetActive(true);
                PlayerPrefs.SetInt(highScoreKey, score);
            }
            else
            {
                _HighScoreView.gameObject.SetActive(false);
            }
        }

        public void ToTitle()
        {
            LoadScene("Title");
        }
    }
}