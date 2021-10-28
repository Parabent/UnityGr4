using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    int x;
    int z;
    private Vector3 vector;
    public Transform tran;
    static int[,] tab = new int[10, 2];
    int count = 1;
    int identical = 0;
    bool isidentical = true;
    int licznik = 9;
    int ez = 1;
    void Start()
    {
        GenerateArray();
        for (int i = 0; i < 10; i++)
        {
            GenerateCube(tab[i, 0], tab[i, 1]);
        }


    }


    void GenerateCube(int x, int z)
    {
        vector.x = x;
        vector.y = 2;
        vector.z = z;
        tran.position = vector;
        GameObject cube = Instantiate(cubePrefab, tran.position, transform.rotation);
    }
    void GeneratePos()
    {
        x = Random.Range(1, 10);
        z = Random.Range(1, 10);

    }
    private bool Compare(int count)
    {
        for (int j = 0; j < count; j++)
        {
            if (tab[j, 0] == x && tab[j, 1] == z)
            {
                Debug.Log("ERRRRRRROR");
                Debug.Log(tab[j, 0]);
                Debug.Log(tab[j, 1]);
                Debug.Log(x);
                Debug.Log(z);
                return true;
            }

        }
        return false;
        //if (identical >count)
        //{
        //    Debug.Log(true);
        //    return true;
        //}
        //else
        //{
        //    Debug.Log(false);
        //    return false;
        //}
    }
    void GenerateArray()
    {
        GeneratePos();
        tab[0, 0] = x;
        tab[0, 1] = z;
        for (int i = 1; i < 10; ++i)
        {
            while (isidentical != false)
            {
                GeneratePos();
                isidentical = Compare(count);
            }
            tab[i, 0] = x;
            tab[i, 1] = z;
            count++;
            identical = 0;
            isidentical = true;

        }
    }
}
