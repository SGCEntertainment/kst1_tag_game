using UnityEngine;

public class HandlerManager : MonoBehaviour
{
    [SerializeField] AudioSource effect;
    [SerializeField] Transform board;
    [SerializeField] Transform root;

    public void PlaySound(AudioClip clip)
    {
        if(effect.isPlaying)
        {
            effect.Stop();
        }

        effect.PlayOneShot(clip);
    }

    public void SetBoardSize3x3()
    {
        board.localScale = new Vector3(0.6099499f, 0.6506132f, 1);
        root.localScale = new Vector3(1.8769f, 1.8769f, 1);
    }

    public void SetBoardSize4x4()
    {
        board.localScale = new Vector3(0.8030407f, 0.8247228f, 1);
        root.localScale = new Vector3(1.4571f, 1.4571f, 1);
    }

    public void SetBoardSize5x5()
    {
        board.localScale = new Vector3(1.009856f, 1.035102f, 1);
        root.localScale = new Vector3(1.1524f, 1.1524f, 1);
    }
}
