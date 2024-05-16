using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public MainMenuMusicManager musicManager;

    public void PlayLevel(int levelNumber)
    {
        if (musicManager != null)
        {
            musicManager.StopMainMenuMusic();
            SceneManager.LoadScene(levelNumber);
        }
    }

    public void Quit()
    {

        Debug.Log("Player has quit the game");
        Application.Quit();

    }

}