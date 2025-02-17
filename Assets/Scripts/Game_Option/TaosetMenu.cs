using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaosetMenu : MonoBehaviour
{
    public GameObject SamSet;
    public float timeSpawn = 0.2f;
    float m_timeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        m_timeSpawn =0;
    }

    // Update is called once per frame
    void Update()
    {
        m_timeSpawn -= Time.deltaTime;
        if(m_timeSpawn <= 0){
        SpawnSamSet();
        m_timeSpawn = timeSpawn;
        }
        
    }
    public void SpawnSamSet()
        {
            Vector2 spawnPos = new Vector2(Random.Range(-5, 5), 100);
            if (SamSet)
            {
                Instantiate(SamSet, spawnPos, Quaternion.identity);
            }
        }
    public void OnTriggerEnter2D(Collider2D col){
        if(col.CompareTag("Sấm sét")){
            Destroy(col.gameObject);
        }
    }
}
