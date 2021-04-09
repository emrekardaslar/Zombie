using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    [SerializeField] Canvas pauseMenu;
    [SerializeField] GameObject player;
    RigidbodyFirstPersonController fpsController;
    private void Start()
    {
        pauseMenu.enabled = false;
        fpsController = player.GetComponent<RigidbodyFirstPersonController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
            }
                
            else
            {
                Pause();
            }
                
        }
    }

    public void Pause()
    {
        gameIsPaused = true;
        Time.timeScale = 0;
        pauseMenu.enabled = true;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        FindObjectOfType<Weapon>().enabled = false;
        fpsController.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 
    }

    public void Resume()
    {
        gameIsPaused = false;
        Time.timeScale = 1;
        pauseMenu.enabled = false;
        fpsController.enabled = true;
        FindObjectOfType<WeaponSwitcher>().enabled = true;
        FindObjectOfType<Weapon>().enabled = true;
    }
}
