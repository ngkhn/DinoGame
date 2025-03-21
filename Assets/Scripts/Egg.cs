using UnityEngine;

public class Egg : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void HideEggShowPlayer()
    {
        gameObject.SetActive(false);
        player.SetActive(true);
        AudioManager.instance.PlayCrackEggClip();
    }
}
