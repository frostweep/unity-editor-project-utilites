using UnityEngine;

namespace FrostweepGames.Internal.Examples
{
    public class Example : MonoBehaviour
    {
        private const string PRIVATE_SECRET_KEY_FOR_DATA = "12345567890qwertyuiop";

        private void Start()
        {
            Utilites.DebugLog("SIMPLE LOG MESSAGE");

            Utilites.DebugWarning("SIMPLE WARNING MESSAGE");

            Utilites.DebugError("SIMPLE ERROR MESSAGE");

            string cryptoData = Utilites.Encrypt("MY SUPER ENCRYPTED DATA", PRIVATE_SECRET_KEY_FOR_DATA);

            Utilites.DebugLog(cryptoData);

            cryptoData = Utilites.Decrypt(cryptoData, PRIVATE_SECRET_KEY_FOR_DATA);

            Utilites.DebugLog(cryptoData);
        }
    }
}