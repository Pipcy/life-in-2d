using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy1;
    [SerializeField] private float enemy1Interval = 3.5f;
    void Start()
    {
        StartCoroutine(spawnEnemy(enemy1Interval, enemy1));

        //GameObject player =  GameObject.Find("YoungPlayer"); 
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy){
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-15f,5),Random.Range(-6f,6),0), Quaternion.identity);
        //GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        // AIDestinationSetter aiPathfinding = newEnemy.GetComponent<AIDestinationSetter>();
        // aiPathfinding.SetTarget(player);

        StartCoroutine(spawnEnemy(interval, enemy));
    }


}
