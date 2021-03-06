using System;
using UnityEngine;

namespace Sounds
{
    public class AudioManager : MonoBehaviour
    {
        public Sound[] sounds;

        private void Awake()
        {
            foreach (var s in sounds)
            {
                s.source = gameObject.AddComponent<AudioSource>();
                s.source.clip = s.clip;
                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
            }
        }

        public void Play(string soundName)
        {
            var s = Array.Find(sounds, sound => sound.name == soundName);
            s.source.Play();
        }
        
    }
}
