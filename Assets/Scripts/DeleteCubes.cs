using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCubes : MonoBehaviour
{
    public static float covered�istance;

    private void Start()
    {
        StartCoroutine(CoroutineDeleteCubes());
    }

    private IEnumerator CoroutineDeleteCubes()
    {
        yield return new WaitForSeconds(covered�istance);
        Destroy(gameObject);
    }
}
