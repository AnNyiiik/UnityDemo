using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public GameObject Player;

    public GameObject Cloud;
    
    void Update()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10f);
    }
}
