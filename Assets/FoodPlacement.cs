using UnityEngine;

public class FoodPlacement : MonoBehaviour
{
    public BoxCollider2D GridArea;

    private void Start()
    {
        RandomizePosition();
    }
    private void RandomizePosition()
    {
        Bounds bounds = this.GridArea.bounds;
        float x= Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        this.transform.position = new Vector3( Mathf.Round(x), Mathf.Round(y), 0);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      if( collision.tag == "Player")
        {
            RandomizePosition();
        }
    }
}
