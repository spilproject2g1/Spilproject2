using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{

    Transform camara;

    public wall[] walls;


    public List<GameObject> hits;

    RaycastHit ray;


    // Start is called before the first frame update
    void Start()
    {
        camara = FindObjectOfType<Camera>().transform;
        walls = FindObjectsOfType<wall>();
        UpdateWalls();
    }

    // Update is called once per frame
    public void UpdateWalls()
    {
        for (int i = 0; i < walls.Length; i++)
        {
            Physics.Raycast(camara.position, walls[i].gameObject.transform.position-camara.position,out ray);
            if (ray.collider.gameObject != null)
            {
                hits.Add(ray.collider.transform.GetChild(0).gameObject);
                walls[i].ChangeSpright(true);
            }
        }
        for (int i = 0; i < walls.Length; i++)
        {
            if (!hits.Contains(walls[i].gameObject))
            {
                walls[i].ChangeSpright(false);
            }
        }
        hits.Clear();
    }

    public void ChangeSpright(bool _index)
    {
        GetComponent<SpriteRenderer>().enabled =_index;
    }
}
