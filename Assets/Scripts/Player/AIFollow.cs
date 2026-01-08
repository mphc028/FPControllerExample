using UnityEngine;

public class AIFollow : MonoBehaviour
{
    private Transform player;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
    }
}
