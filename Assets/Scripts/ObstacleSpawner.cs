using System;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] Transform parentOfObstacles;
    [SerializeField] float obstacleDist;
    [SerializeField] float obstacleY;
    [SerializeField] float obstacles;


    Vector3 vec;
    private void Start()
    {    
        MapBuilder();
    }

    private void MapBuilder()
    {   
        vec.x = 9f;
        for(int obstacle = 0; obstacle < obstacles; obstacle ++)
        {
            vec.x += obstacleDist;
            vec.y = UnityEngine.Random.Range(-obstacleY, obstacleY);

            GameObject mapBuilder = Instantiate(obstaclePrefab, vec, Quaternion.identity);
            mapBuilder.transform.parent = parentOfObstacles;
        }
    }
}
