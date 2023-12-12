using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int totalAliens;
    public int aliensRemaining;
    public GameManager gameManager;

    void Start()
    {
        totalAliens = 27;
        aliensRemaining = totalAliens;
    }

    public void AlienKilled()
    {
        aliensRemaining --;

        Debug.Log("AlienKilled: Remaining Aliens = " + aliensRemaining);

        if (aliensRemaining == 0)
        {
            SceneManager.LoadScene("YouWin");
        }
    }
}
