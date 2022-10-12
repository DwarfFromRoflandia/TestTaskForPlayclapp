using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
   public static UnityEvent<float> SpeedCubesEvent = new UnityEvent<float>();
}
