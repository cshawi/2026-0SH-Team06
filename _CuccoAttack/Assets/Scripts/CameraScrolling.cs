using UnityEngine;

public class CameraScrolling : MonoBehaviour
{
    private Transform player;
    public bool doYAxis = false;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 cameraPosition = transform.position;
        cameraPosition.x = player.position.x;
        if (doYAxis)
        {
            cameraPosition.y = player.position.y;
        }
        transform.position = cameraPosition;
    }
}
