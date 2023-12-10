using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollowScript : MonoBehaviour
{
    public GameObject player;
    Vector3 position;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        position = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float backgroundWidth = GetBackgroundObjectWidth();
        if (player.transform.position.x - transform.position.x > 1.5 * backgroundWidth) {
            position.x += 3 * backgroundWidth;
            transform.position = position;
        }
        
    }

    private float GetBackgroundObjectWidth() {
        return spriteRenderer.sprite.bounds.size.x * transform.localScale.x;
    }
}
