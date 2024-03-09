using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int CurrentScore { get; set; }
    public int EnemiesAlive { get; set; }

    private int EnemiesToSpawn = 0;
    private int EnemiesSpawned = 0;
    private int RandomSpawnPoint = 0;
    private float TimerSpawner = 0;
    public int Wave = 1;


    public bool WaveActive = false;

    public GameObject EnemyPrefab;
    public Transform[] SpawnersTransforms;

    //[SerializeField] private TextMeshProUGUI _scoreText;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        //_scoreText.text = CurrentScore.ToString("0");

    }


    void Update()
    {
        TimerSpawner += Time.deltaTime;
        if (TimerSpawner >= 3 && WaveActive == true)
        {
            SpawnEnemies();
            TimerSpawner = 0;
        }
        else if (TimerSpawner >5 && WaveActive == false)
        {
            WaveValues();
            TimerSpawner = 0;
        }
        
    }

    void SpawnEnemies()
    {

        if (EnemiesSpawned != EnemiesToSpawn)
        {
            RandomSpawnPoint = Random.Range(0, SpawnersTransforms.Length);
            Instantiate(EnemyPrefab, SpawnersTransforms[RandomSpawnPoint].position, Quaternion.identity);
            EnemiesAlive++;
            EnemiesSpawned++;
        }
        else
        {

            if (EnemiesAlive == 0)
            {
                Wave++;
                WaveValues();

            }
        }
    }

    void WaveValues()
    {
        EnemiesToSpawn = Wave * 5;
        EnemiesSpawned = 0;
        WaveActive = true;
    }
   
}
