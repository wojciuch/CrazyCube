using UnityEngine;

public class LeftDistanse : MonoBehaviour {

    private float distanse;
    private Score score;

    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }
    void Update () {
        distanse = GameObject.FindGameObjectWithTag("Finish").GetComponent<Transform>().position.z - transform.position.z;

        if (distanse >= 0.0f)
        {
            score.leftDistanseText.text = "Left distanse : " + distanse.ToString("0");
        }

    }
}
