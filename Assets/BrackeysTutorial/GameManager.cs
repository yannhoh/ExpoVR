using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    bool gameIsOver = false;
    public float restartTime = 2f;
    public GameObject LastScreenUI;
    //public GameObject WelcomeScreenUI;

    public void StartGameM()
    {
        Debug.Log("was");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        //WelcomeScreenUI.SetActive(false);
    }



    public void CompleteLevel()
    {
        LastScreenUI.SetActive(true);

    }




    public void GameOver()
    {
        if (gameIsOver == false)
        {
            gameIsOver = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartTime );
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}