using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPanel; // Reference to the main menu panel
    public GameObject optionsPanel; // Reference to the options panel

    void Start()
    {
        mainMenuPanel.SetActive(true); // Ensure the main menu is visible when starting
        optionsPanel.SetActive(false); // Ensure the options menu is hidden when starting
    }

    public void StartNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogWarning("No next scene available. Add more scenes to the build settings.");
        }
    }

    public void OpenOptions()
    {
        mainMenuPanel.SetActive(false); // Hide the main menu panel
        optionsPanel.SetActive(true); // Show the options panel
    }

    public void CloseOptions()
    {
        mainMenuPanel.SetActive(true); // Show the main menu panel
        optionsPanel.SetActive(false); // Hide the options panel
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit the application (works in builds, not in editor)
    }
}
