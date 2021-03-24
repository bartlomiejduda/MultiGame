using UnityEngine;
using System.Collections;
using System;

public class RandomApple : MonoBehaviour
{
    public GameObject Fruit;
    public int FruitCount;
    public int minX, maxX, minY, maxY;

    void Start()
    {
        InvokeRepeating("GenerateFruits", 0, 2.0f);
    }

    void GenerateFruits()
    {
        for (int i = 0; i < FruitCount; i++)
        {
            Instantiate(Fruit, Position(), Quaternion.identity);
        }
    }

    Vector3 Position()
    {
        int x, y;
        x = UnityEngine.Random.Range(minX, maxX);
        y = UnityEngine.Random.Range(minY, maxY);
        return new Vector3(x, y, 0);
    }
}

