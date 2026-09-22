using UnityEngine;
using Vuforia;

public class ShowButtonOnTarget : MonoBehaviour
{
    private ObserverBehaviour observerBehaviour;
    public GameObject animButton;

    void Start()
    {
        observerBehaviour = GetComponent<ObserverBehaviour>();
        if (observerBehaviour != null)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }

        // Pastikan button tidak terlihat di awal
        animButton.SetActive(false);
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus targetStatus)
    {
        if (targetStatus.Status == Status.TRACKED || targetStatus.Status == Status.EXTENDED_TRACKED)
        {
            animButton.SetActive(true);  // Tampilkan tombol saat marker terdeteksi
        }
        else
        {
            animButton.SetActive(false); // Sembunyikan tombol saat marker hilang
        }
    }
}
