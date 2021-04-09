using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    [SerializeField] Canvas pauseMenu;
    [SerializeField] GameObject player;

    private void Start()
    {
        pauseMenu.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Pause()
    {
        gameIsPaused = true;
        Time.timeScale = 0;
        pauseMenu.enabled = true;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        FindObjectOfType<Weapon>().enabled = false;
        player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
    }

    public void Resume()
    {
        gameIsPaused = false;
        Time.timeScale = 1;
        pauseMenu.enabled = false;
        FindObjectOfType<WeaponSwitcher>().enabled = true;
        FindObjectOfType<Weapon>().enabled = true;
        player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        
    }
}
