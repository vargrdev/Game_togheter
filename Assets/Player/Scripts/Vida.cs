using UnityEngine;

public class Vida : MonoBehaviour
{
   
    public float life = 100f; 
    private Movimento player_movement;

    void Start()
    {
        player_movement=GetComponent<Movimento>();
    
    }

    void Update()
    {
        
        if (life <= 0) 
        {
            if(player_movement != null)
            {
                player_movement.moveSpeed= 0f;

            }
          
        }
    }
}