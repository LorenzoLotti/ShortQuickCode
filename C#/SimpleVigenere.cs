public static class SimpleVigenere
{
    public static void Crypt(in byte[] buffer, byte[] key)
    {
        for (int i = 0, j = 0; i < buffer.Length; i++)
        {
            buffer[i] ^= key[j++];
            if (j == key.Length)
                j = 0;
        }
    }
}
