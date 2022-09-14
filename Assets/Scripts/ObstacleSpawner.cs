using System;using UnityEngine;using Random = UnityEngine.Random;


public enum Mode
{
    easy,
    medium,
    hard
}
public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstaclePrefab;

    public float height = .5f;
    public Mode mode;
    public float maxTime = 0;
    public float destroyDelay = .5f;
    private float timer = 0;

    void Start()
    {
        if (mode == null)
        {
            mode = Mode.easy;
        }
        InstantiateObstacle();
    }
    void Update()
    {
        TimerObstacles();
    }

    private void TimerObstacles()
    {
        if (timer > maxTime)
        {
            #region Instantiation

            InstantiateObstacle();
            #endregion
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void InstantiateObstacle()
    {
        GameObject go = Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
        go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        go.transform.parent = transform;
        if (maxTime > .5f)
        {
            switch (mode)
            {
                
                case Mode.easy:
                    maxTime -= Time.deltaTime;
                    break;
                case Mode.medium:
                    maxTime -= Time.deltaTime * 2f;
                    break;
                case Mode.hard:
                    maxTime -= Time.deltaTime * 3;
                    break;
            }
            
        }
       
        Destroy(go, destroyDelay);
    }
}
