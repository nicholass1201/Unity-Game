using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_MainMenu : MonoBehaviour
{
    public void PlayNowButton()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Cursor.visible = true;
        //Cursor.lockState = CursorLockMode.None;
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
        Debug.Log("Player has quit the game!");
    }
}
