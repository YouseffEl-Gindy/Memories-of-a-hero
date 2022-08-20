using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerCave : MonoBehaviour
{

    public Transform followTarget;

    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    Transform cameraPos;

    void Start()
    {
        cameraPos = GetComponent<Transform>();
        Vector2 twoDPos = new Vector2(minX, maxY);
        cameraPos.position = new Vector3(twoDPos.x, twoDPos.y, -1);
    }


    void FixedUpdate()
    {
        cameraPos.position = Vector3.MoveTowards(cameraPos.position, followTarget.position, 220 * Time.fixedDeltaTime);

        if (cameraPos.position.x > maxX)
            cameraPos.position = new Vector3(maxX, cameraPos.position.y, -1);
        if (cameraPos.position.x < minX)
            cameraPos.position = new Vector3(minX, cameraPos.position.y, -1);
        if (cameraPos.position.y > maxY)
            cameraPos.position = new Vector3(cameraPos.position.x, maxY, -1);
        if (cameraPos.position.y < minY)
            cameraPos.position = new Vector3(cameraPos.position.x, minY, -1);

        cameraPos.position = new Vector3(cameraPos.position.x, cameraPos.position.y, -1);
    }

 
}
