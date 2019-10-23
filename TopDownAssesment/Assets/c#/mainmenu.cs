using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void MainMenu()
    {
     
        SceneManager.LoadScene("game");
    }
    public void Quitgame()
    {
        Application.Quit();
    }
 
}
