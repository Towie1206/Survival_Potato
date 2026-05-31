using System.Collections;
using UnityEngine;

public class FlashRed : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private Material defaultMaterial;
    private Material flashMaterial;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultMaterial = spriteRenderer.material;
        flashMaterial = Resources.Load<Material>("Materials/mRed");
    }
    public void Flash()
    {
        spriteRenderer.material = flashMaterial;
        StartCoroutine(FlashRoutine());
    }

    IEnumerator FlashRoutine()
    {
        yield return new WaitForSeconds(0.2f);
        spriteRenderer.material = defaultMaterial;
    }

    public void Reset()
    {
        spriteRenderer.material = defaultMaterial;

    }
}

