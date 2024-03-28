using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject[] powerups;
    void Start()
    {
        SpawnPowerup();
    }

    IEnumerator SpawnPowerup()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            int randomIndex = Random.Range(-5, powerups.Length + 5);
            Instantiate(powerups[randomIndex], new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0), Quaternion.identity);
        }
    }
}
