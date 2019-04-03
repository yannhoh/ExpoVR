using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour {

    public GameManager gameManager;

    public void StartGame()
    {
        gameManager.StartGameM();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
