using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemySpawn : MonoBehaviour
{
    public Terrain terrian;
    
    public NavMeshAgent agent;
    
    
    public GameObject Enmey;

    [Header("Enemy Spawn Config")]
    public int maxEnemy = 10;
    public int minEnemy = 5;
    
  



    // Start is called before the first frame update
    void Start()
    {
        Vector3 terrianSize = terrian.terrainData.size;
        SpawnEnmey(terrianSize);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    void SpawnEnmey(terrianSize)
    {
          //spawn enemy in random area
        int randEnemy = Random.Range(minEnemy, maxEnemy);

        for (int i = 0; i < randEnemy; i++)
        {
            
            
            int randX = Random.Range(0, (int)terrianSize.x);
            int randZ = Random.Range(0, (int)terrianSize.z);
            float y = terrian.SampleHeight(new Vector3(randX, 0, randZ));

            Vector3 spawnPos = new Vector3(randX, y, randZ);

            Instantiate(Enmey, spawnPos, Quaternion.identity);
        }
    }
}
