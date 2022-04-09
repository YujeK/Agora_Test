using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{

    [SerializeField] private GameObject _settingsPanel;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_settingsPanel.activeSelf == false)
            {
                Cursor.lockState = CursorLockMode.None;
                _settingsPanel.SetActive(true);
            }
            else
            {
                _settingsPanel.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
