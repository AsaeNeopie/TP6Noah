using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Pillier;
    public float TimeToSpawn;
    public float SpawnMax;
    public float SpawnMin;
    private void Start()
    {
        StartSpawn();
    }
    void StartSpawn()
    {
        StartCoroutine(PillierSpawnnig());
    }
    private IEnumerator PillierSpawnnig()
    {
        Instantiate(Pillier, new Vector3(transform.position.x, Random.Range(SpawnMin,SpawnMax),0),Quaternion.identity);
        yield return new WaitForSeconds(TimeToSpawn);
        StartSpawn();
    } 
}
