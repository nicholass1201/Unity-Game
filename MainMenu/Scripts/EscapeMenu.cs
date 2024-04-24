using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{
    public GameObject escapeMenuUI;
    public Button settingsButton;
    public Button restartButton;
    public Button quitButton;

    private bool isMenuOpen = false;

    private void Start()
    {
        // Assign event handlers to the buttons
        settingsButton.onClick.AddListener(OpenSettings);
        restartButton.onClick.AddListener(RestartGame);
        quitButton.onClick.AddListener(QuitGame);

        // Initially hide the escape menu
        escapeMenuUI.SetActive(false);
    }

    private void Update()
    {
        // Toggle the escape menu when the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleEscapeMenu();
        }
    }

    private void ToggleEscapeMenu()
    {
        isMenuOpen = !isMenuOpen;
        escapeMenuUI.SetActive(isMenuOpen);

        // Pause the game when the menu is open, and resume when it's closed
        Time.timeScale = isMenuOpen ? 0f : 1f;
    }

    private void OpenSettings()
    {
        // Load the settings scene
        SceneManager.LoadScene("SettingsScene");
    }

    private void RestartGame()
    {
        // Reload the current scene to restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void QuitGame()
    {
        // Quit the application
        Application.Quit();
    }
}
