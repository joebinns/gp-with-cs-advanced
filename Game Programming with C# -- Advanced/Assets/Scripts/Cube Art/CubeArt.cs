using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeArt : MonoBehaviour
{
    [SerializeField] private List<Material> materials = new List<Material>();

    private int materialIndex = 0;    

    private void Start()
    {
        StartCoroutine(RefreshMaterialRepeating(1f));
    }

    private void RefreshMaterial()
    {
        materialIndex = Random.Range(0, materials.Count);

        gameObject.GetComponent<MeshRenderer>().material = materials[materialIndex];
    }

    private IEnumerator RefreshMaterialRepeating(float interval)
    {
        while (true)
        {
            RefreshMaterial();
            yield return new WaitForSeconds(interval);
        }
    }
}
