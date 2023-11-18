using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private float followSpeed = 1f;
    public float yOffset = 0f;
    public float xOffset = 0f;
    private Vector3 lastPlayerPos;
    private float distanceToMove;

    // Start is called before the first frame update
    void Start()
    {
        lastPlayerPos = player.transform.position;
        transform.position = new Vector3(lastPlayerPos.x + 2f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        LerpCamera();
    }

    void LerpCamera()
    {
        Vector3 newPos = new Vector3(player.transform.position.x + xOffset, player.transform.position.y + yOffset, -1f);
        transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
    }
}
