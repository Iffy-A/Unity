using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public Button startButton;
    public Button optionsButton;
    public Button quitButton;

    void playGame() { SceneManager.LoadScene(2); }
    void options() { SceneManager.LoadScene(1); }
    void quit() { Application.Quit(); }
}