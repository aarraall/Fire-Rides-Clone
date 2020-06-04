using System;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] Transform parentOfObstacles;
    [SerializeField] float obstacleDist;
    [SerializeField] float obstacleY;
    [SerializeField] float obstacles;

    [SerializeField] GameObject scoreBasketPrefab;
    [SerializeField] Transform parentOfScoreBaskets;
    [SerializeField] float scoreBasketDist;
    [SerializeField] float scoreBasketY;
    [SerializeField] float scoreBasketNum;


    Vector3 vec;
    private void Start()
    {    
        MapBuilder();
        ScoreBasketGenerator();
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
    private void ScoreBasketGenerator()
    {
        vec.x = 18f;
        for (int scoreBasket = 0; scoreBasket < scoreBasketNum; scoreBasket++)
        {
            vec.x += scoreBasketDist;
            vec.y = UnityEngine.Random.Range(-scoreBasketY, scoreBasketY);

            GameObject scoreBasketGenerator = Instantiate(scoreBasketPrefab, vec, Quaternion.identity);
            scoreBasketGenerator.transform.parent = parentOfScoreBaskets;
        }
    }
}
