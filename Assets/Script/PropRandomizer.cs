using System.Collections.Generic;
using UnityEngine;

public class PropRandomizer : MonoBehaviour
{
    public List<GameObject> propSpawnPoint;
    public List<GameObject> propsPrefab;

    void Start()
    {
        SpawnProp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnProp()
    {
        foreach (GameObject sp in propSpawnPoint)
        {
            int rad = Random.Range(0, propsPrefab.Count);
            GameObject prop = Instantiate(propsPrefab[rad], sp.transform.position, Quaternion.identity);
            prop.transform.parent = sp.transform;
        }    
    }    
}
