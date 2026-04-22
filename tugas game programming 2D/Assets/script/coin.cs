using System.Collections;
using UnityEngine;

public class coin : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    IEnumerator waitAndLog()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.linearVelocity = new Vector2(rigidbody2D.linearVelocity.x,5f);
        StartCoroutine(waitAndLog());
    }
}
