using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreceduralGeneration : MonoBehaviour
{
    [SerializeField] private Transform plane;

    Vector2 deltaPosition = new Vector2(11f,0);
    Vector2 startPosition = new Vector2(22f,-5.30f);
    // Vector2 currentPosition = startPosition;

    // Start is called before the first frame update

    void OnTriggerEnter(Collider instantiationTrigger)
    {
        if (instantiationTrigger.tag == "trigger")
        {
            InstantiatePlane();
        }
    }

    void InstantiatePlane()
    {
        Instantiate(plane, startPosition, Quaternion.identity);
        startPosition += deltaPosition;
    }
}
