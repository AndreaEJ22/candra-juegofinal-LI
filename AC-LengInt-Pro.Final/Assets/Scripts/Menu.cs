using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void quit()
    {
        SceneManager.LoadScene("quit");
    }
    public void menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}