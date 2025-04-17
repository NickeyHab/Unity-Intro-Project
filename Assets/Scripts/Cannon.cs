using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform projectileSpawn;
    [SerializeField] private float delay = 2f;
    [SerializeField] private float interval = 1f;
    [SerializeField] private float projectileSpeed = 20f;
    [SerializeField] private float projectileDuration = 5f;
    [SerializeField] private AudioClip projectileSFX;
    private AudioSource audioSource;


    void Start()
    {
        InvokeRepeating("Shoot", delay, interval);
        audioSource = GetComponent<AudioSource>();
    }

    private void Shoot()
    {
        GameObject projectileGameObject = Instantiate(projectilePrefab, projectileSpawn.position, projectileSpawn.rotation);
        Projectile projectile = projectileGameObject.GetComponent<Projectile>();
        projectile.SetSpeed(projectileSpeed);
        audioSource.PlayOneShot(projectileSFX);
    }
    void Update()
    {
        
    }
}
