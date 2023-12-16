using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    // Start is called before the first frame update
    public int attempts;

    public void RestartGame() {
        Debug.Log("Restart");
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
