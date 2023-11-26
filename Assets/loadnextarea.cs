using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadnextarea : MonoBehaviour
{
    public int pillar_index;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (blockmanager.Instance.active_pillar_index == pillar_index)
            blockmanager.Instance.MakeBlocks();
    }
}
