using UnityEngine;

namespace PhantomDragonStudio.HeroSystem
{
    [System.Serializable]
    public class GeneralObjectInformation
    {
        [SerializeField] private string name;
        [SerializeField] private string description;
        [SerializeField] private Sprite sprite;

        public GeneralObjectInformation(string name, string description, Sprite sprite, GameObject gameObject)
        {
            this.name = name;
            this.description = description;
            this.sprite = sprite;
        }

        public string Name { get => name; }
        public string Description { get => description; }
        public Sprite Sprite { get => sprite; }
    }
}
