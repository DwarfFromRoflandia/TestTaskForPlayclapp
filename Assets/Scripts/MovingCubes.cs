using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCubes : MonoBehaviour
{
    private bool isPlatform = false;
    private void Start()
    {
        EventManager.SpeedCubesEvent.AddListener(StartRunValues);
    }

    private void StartRunValues(float speed)
	{
        if (isPlatform) transform.Translate(0, 0, speed * Time.deltaTime, Space.World);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform")) isPlatform = true;
    }
}
    