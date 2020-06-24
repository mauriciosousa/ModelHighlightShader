using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightColor : MonoBehaviour
{
    public Transform target;
    public float radius = 1f;

    private MeshRenderer _meshRenderer;
    private Material _material;

    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _material = Resources.Load("Materials/Highlight") as Material;
        _meshRenderer.material = _material;
    }

    // Update is called once per frame
    void Update()
    {
        _meshRenderer.material.SetVector("_TargetPos", target.transform.position);
        _meshRenderer.material.SetFloat("_Radius", radius);
    }
}
