using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockmanager : MonoBehaviourSingleton<blockmanager>
{
    [SerializeField] GameObject block;
    [SerializeField] GameObject tower;

    [SerializeField] float blocks_x = 20;

    public int active_pillar_index = 0;

    void Start()
    {
        MakeBlocks();
    }

    public void MakeBlocks()
    {
        active_pillar_index += 1;

        Transform new_tower = Instantiate(tower).transform;
        new_tower.position = transform.position + Vector3.right*.5f - Vector3.up * (new_tower.lossyScale.y/2f - 2f);

        new_tower.GetComponentInChildren<loadnextarea>().pillar_index = active_pillar_index;

        // spawn grid of blocks
        for (int x = 0; x < blocks_x; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                Transform new_block = Instantiate(block).transform;
                new_block.position = new Vector3(transform.position.x+x+2,transform.position.y-y,0);

                new_block.GetComponent<deleteafter>().y = y+1;
            }
        }

        // move to next area
        transform.position += Vector3.right * (blocks_x + 2); 
    }
}
