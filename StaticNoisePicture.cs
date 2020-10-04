using UnityEngine;

public class StaticNoisePicture : MonoBehaviour
{
    [SerializeField] GameObject pixelPrefab;

    [Header("Resolution")]
    [SerializeField] int width;
    [SerializeField] int height;

    void Start()
    {
        for (int i = 0; i <= height; i++)
        {
            for (int j = 0; j <= width; j++)
            {
                GameObject pixel = Instantiate(pixelPrefab);

                pixel.transform.position = new Vector3(j, 0, i);

                pixel.name = "Pixel";

                float color = Random.Range(0f, 1f);

                pixel.transform.localScale = new Vector3(pixel.transform.localScale.x, (color + 0.01f) * 5, pixel.transform.localScale.z);

                pixel.GetComponent<MeshRenderer>().material.color = new Color(color, color, color);
            }
        }
    }
}
