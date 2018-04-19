using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMenu : MonoBehaviour {

    public Canvas mainMenu;
    public Canvas optionsMenu;
    public AudioSource music;

    private void Awake()
    {
        optionsMenu.enabled = false;
        playMusic();
    }

    public void OptionsOn()
    {
        mainMenu.enabled = false;
        optionsMenu.enabled = true;
    }

    public void Return()
    {
        mainMenu.enabled = true;
        optionsMenu.enabled = false;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("game-scene");

    }

    public void Sound()
    {
        if (PlayerPrefs.GetInt("gameSound", 1) == 1)
        {
            stopMusic();
        }
        else
        {
            playMusic();
        }
    }

    void playMusic()
    {
        PlayerPrefs.SetInt("gameSound", 1);
        music.Play();
        music.loop = true;
    }

    void stopMusic()
    {
        PlayerPrefs.SetInt("gameSound", 0);
        music.Pause();
    }

}
