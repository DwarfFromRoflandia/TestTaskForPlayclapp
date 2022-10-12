using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
    [SerializeField] private GameObject PrefabCube;
   
    public static float timeSpawnCubes;

    private void Start()
    {
        StartCoroutine(CoroutineSpawnCubes());
    }

    private IEnumerator CoroutineSpawnCubes()
    {
        while (true)
        {
             Instantiate(PrefabCube, gameObject.transform);
 
             yield return new WaitForSeconds(timeSpawnCubes);
        }
    }
}
