using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFall : MonoBehaviour
{
    public static float xOrigin = 0;
    public static float yOrigin = 900;
    public static float zOrigin = 0;
    public static float xDestination = 0;
    public static float yDestination = 105;
    public static float zDestination = 0;

    public Vector3 Origin = new Vector3(xOrigin, yOrigin, zOrigin);
    public Vector3 Destination = new Vector3(xDestination, yDestination, zDestination);

    public static bool activate = false;

    public IEnumerator moveObject()
    {
        float totalMovementTime = 1.5f;
        float currentMovementTime = 0f;
        while (Vector3.Distance(transform.localPosition, Destination) > 0)
        {
            currentMovementTime += Time.deltaTime;
            if (currentMovementTime >= totalMovementTime) activate = true;
            transform.localPosition = Vector3.Lerp(Origin, Destination, currentMovementTime / totalMovementTime);
            
            yield return null;
        }
    }
    void Start()
    {
        StartCoroutine(moveObject());
    }
}
