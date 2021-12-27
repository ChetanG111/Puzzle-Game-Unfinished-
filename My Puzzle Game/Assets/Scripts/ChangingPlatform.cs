using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingPlatform : MonoBehaviour
{
  public enum ChangeCase
    {
        Black,
        White,
    }

    public ChangeCase Ccase;
    public float time;
    float defTime;
    private void Awake()
    {
        defTime = time;
    }


    private void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            Ccase = Ccase == ChangeCase.Black ? ChangeCase.White : ChangeCase.Black;
            time = defTime;
        }

        if (Ccase == ChangeCase.White)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else if (Ccase == ChangeCase.Black)
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (Ccase == ChangeCase.White)
        {
            Debug.Log("None");
        }
        else if (Ccase == ChangeCase.Black)
        {
            Debug.Log("Close");
        }
    }
}
