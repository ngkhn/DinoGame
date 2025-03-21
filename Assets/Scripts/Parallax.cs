using Unity.Hierarchy;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Material material;
    [SerializeField] private float parallaxFactor = 0.01f;
    private float offset;
    //public float gameSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        ParallaxScoll();
    }

    private void ParallaxScoll()
    {
        float speed = GameManager.instance.GetGameSpeed() * parallaxFactor;
        offset += speed * Time.deltaTime;
        material.SetTextureOffset("_MainTex", Vector2.right * offset);
    }
}
