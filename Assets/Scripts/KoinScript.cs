using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoinScript : MonoBehaviour
{
    int posX = 0;
    int posZ = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("map") == "0")
        {
            transform.position = new Vector3(posX, 0.5f, posZ);
            posX = Random.Range(-13, 13);
            posZ = Random.Range(-97, 30);
            gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetString("map") == "1")
        {
            transform.position = new Vector3(posX, 0.5f, posZ);
            posX = Random.Range(-13, 11);
            posZ = Random.Range(-42, 10);
            gameObject.SetActive(true);
        }
        InvokeRepeating("spawnPeriodic", 0, 10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        TankCoin target = other.GetComponent<TankCoin>();
        if (target)
        {
            // Debug.Log(target.coins);
            gameObject.SetActive(false);
            target.coins++;
        }
        // Debug.Log(other.name);
    }

    private void spawnPeriodic()
    {
        if (!gameObject.activeSelf)
        {
            if(PlayerPrefs.GetString("map") == "0")
            {
                transform.position = new Vector3(posX, 0.5f, posZ);
                posX = Random.Range(-13, 13);
                posZ = Random.Range(-97, 30);
                gameObject.SetActive(true);
            }
            if (PlayerPrefs.GetString("map") == "1")
            {
                transform.position = new Vector3(posX, 0.5f, posZ);
                posX = Random.Range(-13, 11);
                posZ = Random.Range(-42, 10);
                gameObject.SetActive(true);
            }
        }
    }
}
