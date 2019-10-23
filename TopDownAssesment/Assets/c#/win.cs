using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
   private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "nextleve")
        {
            SceneManager.LoadScene("level 2");
        }
        if (collision.gameObject.tag == "win")
        {
            SceneManager.LoadScene("win");
        }
    }
}
