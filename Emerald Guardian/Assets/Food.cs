
using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;
    /*private int score =0; */
    private void Start()
    {
        RandomizePosition();
    }

    private void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){
            /*
            score  += 1;
            Debug.Log(score); */

            RandomizePosition();
        }
        
    }
}
