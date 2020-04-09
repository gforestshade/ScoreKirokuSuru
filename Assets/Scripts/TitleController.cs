using UnityEngine;
using static UnityEngine.SceneManagement.SceneManager;

namespace ScoreKirokuSuru
{
    public class TitleController : MonoBehaviour
    {
        public void StartGame(int stage)
        {
            // ステージ番号をセットしてシーンを変える
            SceneParams.Params.Stage = stage;
            LoadScene("Game");
        }

        public void ToHighScore()
        {
            LoadScene("HighScore");
        }
    }
}
