using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{

    Transform camara;

    wall[] walls;


    public List<GameObject> hits;

    RaycastHit ray;


    public Sprite[] textures;


    // Start is called before the first frame update
    void Start()
    {
        camara = FindObjectOfType<Camera>().transform;
        walls = FindObjectsOfType<wall>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < walls.Length; i++)
        {
            Physics.Raycast(camara.position, walls[i].gameObject.transform.position-camara.position,out ray);
            if (ray.collider.gameObject != null)
            {
                hits.Add(ray.collider.GetComponentInChildren<Transform>().gameObject);
                walls[i].ChangeSpright(0);
            }
        }
        for (int i = 0; i < walls.Length; i++)
        {
            if (!hits.Contains(walls[i].gameObject))
            {
                walls[i].ChangeSpright(1);
            }
        }
        hits.Clear();
    }

    void ChangeSpright(int _index)
    {
        GetComponent<SpriteRenderer>().sprite = textures[_index];
    }
}
