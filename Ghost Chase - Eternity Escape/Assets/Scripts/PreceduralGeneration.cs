using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreceduralGeneration : MonoBehaviour
{
    [SerializeField] private Transform plane1;
    [SerializeField] private Transform plane2;
    [SerializeField] private Transform plane3;
    [SerializeField] private Transform plane4; //taking multiple planes for multiple prefabs containing different obstacles

    Vector2 deltaPosition = new Vector2(11f,0);
    Vector2 startPosition = new Vector2(19f,-5.30f); //position of first ground plane prefab on which the player is standing in the beginning

    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D instantiationTrigger)
    {
        Debug.Log("Triggered");
        InstantiatePlane();
    }

    public void InstantiatePlane()
    {
        //for randomly deciding which prefab will be instantiated
        int prefabIndex = Random.Range(1,4);
        if (prefabIndex == 1)
        {
            Instantiate(plane1, startPosition, Quaternion.identity);
        }
        if (prefabIndex == 2)
        {
            Instantiate(plane2, startPosition, Quaternion.identity);
        }
        if (prefabIndex == 3)
        {
            Instantiate(plane3, startPosition, Quaternion.identity);
        }
        if (prefabIndex == 4)
        {
            Instantiate(plane4, startPosition, Quaternion.identity);
        }
        startPosition += deltaPosition;
    }
}
