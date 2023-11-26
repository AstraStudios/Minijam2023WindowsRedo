using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteafter : MonoBehaviour
{
    [SerializeField] float min = .5f;
    [SerializeField] float max = 10f;

    public float y = 0;

    float timer;

    void Start()
    {
        timer = Random.Range(min, max);
        timer *= Mathf.Sqrt(y);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
            Destroy(gameObject);
    }
}
