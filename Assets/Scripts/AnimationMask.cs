using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMask : MonoBehaviour
{
    public GameObject enemyPerson;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Enemy enemy = enemyPerson.gameObject.GetComponent<Enemy>();
        
        transform.position = enemy.location;
        transform.Translate(0, -4, 0);
    }
}
