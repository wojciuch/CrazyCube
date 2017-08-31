using UnityEngine;

public class FallowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    
    private void Update()
    {
      //  Debug.Log(transform.position.x + "  " + transform.position.y + "  " + transform.position.z);
        if(!float.IsNaN(transform.position.x) && !float.IsNaN(transform.position.y) && !float.IsNaN(transform.position.z))
        {
            transform.position = player.position + offset;
        }
     }
}
