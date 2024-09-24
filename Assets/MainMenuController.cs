using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SpaceSurvive"); // This will load your gameplay scene.
    }

    public void OpenOptions()
    {
        // Add code to open options UI or scene.
    }

    public void QuitGame()
    {
        Application.Quit(); // This will close the game.
    }
}