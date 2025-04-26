using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Game_Over : MonoBehaviour
{
    public GameObject gameOverPanel;
    public float overTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            StartCoroutine(gameOver());
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    IEnumerator gameOver()
    {
        yield return new WaitForSeconds(1);
        gameOverPanel.SetActive(true);
    }
}
