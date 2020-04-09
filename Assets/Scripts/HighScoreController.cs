using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.SceneManagement.SceneManager;

namespace ScoreKirokuSuru
{

    public class HighScoreController : MonoBehaviour
    {

        [SerializeField]
        Text _EasyScoreView = default;

        [SerializeField]
        Text _NormalScoreView = default;

        [SerializeField]
        Text _HardScoreView = default;


        private void Start()
        {
            // これでいいのでは
            _EasyScoreView.text =   PlayerPrefs.GetInt("highscore_0", 0).ToString();
            _NormalScoreView.text = PlayerPrefs.GetInt("highscore_1", 0).ToString();
            _HardScoreView.text =   PlayerPrefs.GetInt("highscore_2", 0).ToString();
        }

        public void Back()
        {
            LoadScene("Title");
        }

        public void Erase()
        {
            // これでいいのでは
            PlayerPrefs.DeleteKey("highscore_0");
            PlayerPrefs.DeleteKey("highscore_1");
            PlayerPrefs.DeleteKey("highscore_2");
            Back();
        }
    }
}

