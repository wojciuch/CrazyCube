using UnityEngine;

public class FallowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    private string position;
    
    private void Update()
    {
        position = player.position.x.ToString();
        if (position == ("NaN"))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        else
        {
            transform.position = player.position + offset;
        }
    }
}
