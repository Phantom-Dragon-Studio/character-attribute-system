using System;
using UnityEngine;

public class MagicProjectileSpawner : MonoBehaviour
{
    [SerializeField] private Settings _settings = default;

    public void CreateMagicBolt(Vector3 spawnPoint, Quaternion spawnRotation)
    {
        Instantiate(_settings.myData.SFX, spawnPoint, spawnRotation, null);
    }

    [Serializable]
    public class Settings
    {
        [SerializeField] public ProjectileData myData;
    }
}
