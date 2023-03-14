using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private GameObject _enemy;
    
    void Update()
    {
        if (_enemy == null)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject;
            float position = Random.Range(6, -6);
            float position2 = Random.Range(-3, -16);
            _enemy.transform.position = new Vector3(position, 0, position2);
            _enemy.transform.Rotate(0,0,0);
        }
    }
}