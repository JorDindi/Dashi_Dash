using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuHolder;
    [SerializeField] private GameObject player;
    [SerializeField] private Animator anim;
    public void pauseMenu()
    {
        pauseMenuHolder.SetActive(true);
        player.GetComponent<MovementScript>().enabled = false;
        anim.SetTrigger("Popup");
    }
    public void resumeGame()
    {
        pauseMenuHolder.SetActive(false);
        player.GetComponent<MovementScript>().enabled = true;
    }
    public void goHome() => SceneManager.LoadScene("Home");
    public void startGame() => SceneManager.LoadScene("Level1");
    public void restartLevel() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
