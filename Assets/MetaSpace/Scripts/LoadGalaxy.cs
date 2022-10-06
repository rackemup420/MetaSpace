using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MetaSpace
{
  public class LoadGalaxy : MonoBehaviour
  {
    public void LoadGalaxyButton(string galaxy)
    {
      SceneManager.LoadScene(galaxy);
    }
  }
}
