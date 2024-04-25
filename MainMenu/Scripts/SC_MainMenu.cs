using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
        Debug.Log("Player has quit the game!");
    }
    // Function to toggle visibility of the main menu
    public void ToggleMainMenu(bool show)
    {
        MainMenu.SetActive(show);
        // Lock or unlock cursor based on menu visibility
        Cursor.lockState = show ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = show;
    }
}

