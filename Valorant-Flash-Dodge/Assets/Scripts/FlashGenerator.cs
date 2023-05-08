using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashGenerator : MonoBehaviour
{
    float spawnInterval;
    float randomX;
    float randomY;

    public GameObject flash;

    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        float spawnInterval = Random.Range(1.0f, 10.0f);

        coroutine = WaitAndFlash(spawnInterval);
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnFlash()
    {
        float randomX = Random.Range(-10f, 10f);
        float randomY = Random.Range(2f, 18f);

        Instantiate(flash, new Vector3(randomX, randomY, 20f), Quaternion.identity);
    }

    private IEnumerator WaitAndFlash(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SpawnFlash();
    }
}
