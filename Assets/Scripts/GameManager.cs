using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public GameObject completLevelUI;
    private Score score;

    public bool levelIsComplete;

    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        levelIsComplete = false;

        if (PlayerPrefs.HasKey("Score"))
        {
            if (Application.loadedLevel == 1)
            {
                PlayerPrefs.DeleteKey("Score");
                score.score = 0f;
            }
            else
            {
                score.score = PlayerPrefs.GetFloat("Score");
            }
        }
    }

    public void CompletLevel()
    {
        completLevelUI.SetActive(true);
        swichLevelIsComplete();
    }

    public float restartDelay = 1f;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            swichLevelIsComplete();
            gameHasEnded = true;
            Debug.Log("GAME OVER !");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        //SceneManager.LoadScene(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void swichLevelIsComplete ()
    {
        levelIsComplete = true;
    }
}
