using UnityEngine;

public class flyatplayer : MonoBehaviour
{[SerializeField] float speed=1f;
   [SerializeField] Transform player;
   Vector3 playerpos;
    void Awake() {
    gameObject.SetActive(false);
   }
    void Start()
    { 
        playerpos=player.transform.position;
    }

       void Update()
    { 
        transform.position=
        Vector3.MoveTowards(transform.position,playerpos,Time.deltaTime*speed);
        DestroyWhenReached();
    }
    void DestroyWhenReached()
    {
        if(transform.position==playerpos)
        {
            Destroy(gameObject);
        }
    }
}
