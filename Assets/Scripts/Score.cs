using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour {

   
    public float score;
    public Text scoreText;
    public Text levelText;
    public float scoreMultipler;

    private GameManager gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        levelText.text = "Level  : "+ SceneManager.GetActiveScene().buildIndex +" / 3";
    }

    private void Update()
    {

        if (!gm.levelIsComplete)
        {
            score = score + Time.deltaTime * scoreMultipler;
            scoreText.text = score.ToString("0") ;
        }
        else
        {
            scoreText.text = score.ToString("0") ;
        }
        

    }





}

