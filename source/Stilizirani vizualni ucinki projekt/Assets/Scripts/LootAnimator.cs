using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class LootAnimator : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    [SerializeField]
    private GameObject island, brokenIsland;


    //rarity
    [SerializeField]
    private MeshRenderer crystalMeshRenderer;

    [SerializeField]
    private Material loot, epicLoot, legendaryLoot;

    [SerializeField]
    private List<VisualEffect> crystalEffects;

    [SerializeField]
    private int rarity = 0;


    private int originalRarity;

    private void Start()
    {
        island.SetActive(true);
        brokenIsland.SetActive(false);

        originalRarity = rarity;

        if (originalRarity == -1)    //set random rarity
            rarity = (int)Random.Range(0, 3);
    }

    private void Reset()
    {
        island.SetActive(true);
        brokenIsland.SetActive(false);
        anim.SetBool("Open", false);
        anim.Play("Idle");

        if (originalRarity == -1)    //set random rarity
            rarity = (int)Random.Range(0, 3);
    }

    public void Float()
    {
        island.SetActive(false);
        brokenIsland.SetActive(true);
    }

    public void SetRarity()
    {
        //set crystal material based on rarity
        switch (rarity)
        {
            case 0:
                crystalMeshRenderer.material = loot;
                break;
            case 1:
                crystalMeshRenderer.material = epicLoot;
                break;
            case 2:
                crystalMeshRenderer.material = legendaryLoot;
                break;
            default:
                crystalMeshRenderer.material = loot;
                break;
        }

        //set colors for vfx systems based on rarity
        foreach (VisualEffect vfx in crystalEffects)
            vfx.SetInt("Rarity", rarity);
    }
}
