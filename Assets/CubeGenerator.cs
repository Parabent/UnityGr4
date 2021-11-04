using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 1.0f;
    int objectCounter = 0;
    public int cubes;
    // obiekt do generowania
    public GameObject block;
    public Vector3 vec;
    public Vector3 bounds;
    Renderer rend;
    public Material[] randomMaterials;

    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        vec.x = transform.position.x;
        vec.y = 3;
        vec.z = transform.position.z;
        rend = GetComponent<Renderer>();
        bounds.x = rend.bounds.size.x;
        bounds.y = 1;
        bounds.z = rend.bounds.size.z;
        Debug.Log(vec);
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range(Convert.ToInt32(vec.x - (bounds.x/2)), Convert.ToInt32(vec.x + (bounds.x / 2))).OrderBy(x => Guid.NewGuid()).Take(cubes));
        List<int> pozycje_z = new List<int>(Enumerable.Range(Convert.ToInt32(vec.z - (bounds.x / 2)), Convert.ToInt32(vec.z + (bounds.x / 2))).OrderBy(x => Guid.NewGuid()).Take(cubes));

        for (int i = 0; i < cubes; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], cubes/2, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywo³ano coroutine");
        foreach (Vector3 pos in positions)
        {
            this.block.GetComponent<Renderer>().material = randomMaterials[UnityEngine.Random.Range(0, randomMaterials.Length)];
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}
