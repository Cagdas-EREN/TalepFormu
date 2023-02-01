using Entities.Concrete;

namespace MernisDogrulaApp
{
    public class TcNoDogrula
    {
        public Task<bool> TcKimlikDogrula(KisiselBilgiler kisiselBilgiler)
        {
            bool dogrulamaSonucu = false;

            try
            {
                var mernisClient = new MernisService.KPSPublicSoapClient(MernisService.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync(long.Parse(kisiselBilgiler.TCNO), kisiselBilgiler.Ad, kisiselBilgiler.Soyad, kisiselBilgiler.DogumTarihi.Year).GetAwaiter().GetResult();
                dogrulamaSonucu = tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
            }
            catch (Exception ex)
            {
                dogrulamaSonucu = false;
            }

            return Task.FromResult(dogrulamaSonucu);
        }
    }
}