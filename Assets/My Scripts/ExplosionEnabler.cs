using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEnabler : MonoBehaviour
{
    public List<ParticleSystem> ps;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            foreach(ParticleSystem p in ps)
            {
                p.gameObject.SetActive(true);
                p.Play();
            }
        }
    }
}
