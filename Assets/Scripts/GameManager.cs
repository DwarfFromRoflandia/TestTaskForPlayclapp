using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class GameManager : MonoBehaviour
{  
    [SerializeField] private InputField inputFieldSpeedCubes;
    [SerializeField] private InputField inputTimeSpawn;
    [SerializeField] private InputField inputDistanse;
       
    private float speedCube;
    private float timeSpawn;
    private float distanse;

    private void Awake()
    {
        inputFieldSpeedCubes.text = "0";
        inputTimeSpawn.text = "0";
        inputDistanse.text = "0";
    }

    private void Update()
    {
        speedCube = float.Parse(inputFieldSpeedCubes.text);
        timeSpawn = float.Parse(inputTimeSpawn.text);
        distanse = float.Parse(inputDistanse.text);

        DeleteCubes.coveredÂistance = distanse;
        SpawnCubes.timeSpawnCubes = timeSpawn;
    }
   
    private void FixedUpdate()
    {
        if (EventManager.SpeedCubesEvent != null) EventManager.SpeedCubesEvent.Invoke(speedCube);
    }
}
