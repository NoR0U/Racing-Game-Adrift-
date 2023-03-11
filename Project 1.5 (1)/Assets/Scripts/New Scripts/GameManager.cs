using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public InputController InputController { get; private set; }



    void Awake()
    {
        Instance = this;
        InputController = GetComponentInChildren<InputController>();
    }



    void Update()
    {
        
    }
}
