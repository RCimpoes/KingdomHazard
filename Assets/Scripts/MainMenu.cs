using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class MainMenu : MonoBehaviour {

        public void PlayGame(int indexScene)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void LoadNextScene()
        {
            SceneManager.LoadScene(1);
        }

        public void QuitGame()
        {
            Debug.Log("PAaa!");
            Application.Quit();
        }

    }
}
