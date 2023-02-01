namespace MvcUI.Data
{
    public static class TCKimlikKontrol
    {
        public static string Kontrol(string TCno)
        {
            int Algoritma_Adim_Kontrol = 0, TekBasamaklarToplami = 0, CiftBasamaklarToplami = 0, TumBasamaklarToplami = 0, Basamak_10 = 0, Basamak_11 = 0;

            if (TCno.Length == 11) Algoritma_Adim_Kontrol = 1;

            foreach (char chr in TCno) { if (Char.IsNumber(chr)) Algoritma_Adim_Kontrol = 2; }

            if (TCno.Substring(0, 1) != "0") Algoritma_Adim_Kontrol = 3;

            int[] arrTC = System.Text.RegularExpressions.Regex.Replace(TCno, "[^0-9]", "").Select(x => (int)Char.GetNumericValue(x)).ToArray();

            for (int i = 0; i < TCno.Length; i++)
            {
                TumBasamaklarToplami += Convert.ToInt32(arrTC[i]);
                if (((i + 1) % 2) == 0)
                {
                    if (i + 1 != 10) CiftBasamaklarToplami += Convert.ToInt32(arrTC[i]);
                    else Basamak_10 = Convert.ToInt32(arrTC[i]);
                }
                else
                {
                    if (i + 1 != 11) TekBasamaklarToplami += Convert.ToInt32(arrTC[i]);
                    else
                    {
                        Basamak_11 = Convert.ToInt32(arrTC[i]);
                        TumBasamaklarToplami = TumBasamaklarToplami - Basamak_11;
                    }
                }
            }

            int ilkDeger = (TekBasamaklarToplami * 7) - CiftBasamaklarToplami;
            int ilkDeger_mod10 = ilkDeger % 10;
            if (Basamak_10 == ilkDeger_mod10) Algoritma_Adim_Kontrol = 4;

            int ikinciDeger_mod10 = TumBasamaklarToplami % 10;
            if (Basamak_11 == ikinciDeger_mod10) Algoritma_Adim_Kontrol = 5;

            if (Algoritma_Adim_Kontrol == 5)
                return "TC No Doğru";
            else
                return "TC No Yanlış";
        }
    }
}
