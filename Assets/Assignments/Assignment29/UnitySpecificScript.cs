using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UnitySpecificScript : MonoBehaviour
{
    GameObject TargetObject;
    GameObject JokerObject;
    Light LLight;
    void OnEnable()
    {
        print("GameObject Enabled");
    }

    void OnDisable()
    {
        print("GameObject Disabled");
    }
    void Start()
    {
        print("Game started");
        //
        TargetObject = GameObject.Find("TargetObject");
        if (TargetObject != null)
        {
            print($"Found object by name:{TargetObject.name}");

        }
        else
        {
            print("No TargetObject  found");
        }
        //
        JokerObject = GameObject.FindGameObjectWithTag("Joker");

        if (JokerObject != null)
        {
            print($"Found object by tag: {JokerObject.name}");
        }
        else
        {
            print("No Joker object found");
        }
        //
        LLight = GameObject.FindObjectOfType<Light>();
        if (LLight != null)
        {
            print($"Found object of type Light: {LLight.name}");
        }
        else
        {
            print("No Light object found");
        }






    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (TargetObject != null)
            {
                TargetObject?.SetActive(false);
                print("TargetObject deactivated!");
            }
            else
            {
                print("TargetObject is null ");
            }
        }
    }
}