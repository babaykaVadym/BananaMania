using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaGenerator : MonoBehaviour
{
    public GameObject[] banana;
    public float minX, maxX;
    public float minSpeed, maxSpeed;
    public float minScale, maxScale;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, interval);
    }
    // Update is called once per frame
    void Spawn()
    {
        GameObject star = banana[Random.Range(0, banana.Length)];
        Vector2 pos = new Vector2( Random.Range(minX, maxX), transform.position.y);
        float scl = Random.Range(minScale, maxScale);
        Vector3 scale = new Vector3(scl, scl, scl);
        float speeds = Random.Range(minSpeed, maxSpeed);
      

        GameObject s = Instantiate(star, pos, Quaternion.identity) as GameObject;
        s.GetComponent<MoveBanana>().speed = speeds;
        s.transform.localScale = scale;
    }
}
