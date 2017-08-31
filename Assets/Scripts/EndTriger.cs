using UnityEngine;

public class EndTriger : MonoBehaviour {

    public GameManager gameManager;
    private Score score;

    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        SaveScore();
        gameManager.CompletLevel();
    }

    private void SaveScore ()
    {
        PlayerPrefs.SetFloat("Score", score.score);
    }
}
