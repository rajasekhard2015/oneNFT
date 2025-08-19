using Microsoft.AspNetCore.Mvc;
using oneNFT.Services;

namespace oneNFT.Controllers
{
    public static class WalletController
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/wallet/{address}", ([FromServices] WalletService walletService, string address) =>
            {
                var wallet = walletService.GetWallet(address);
                return wallet != null ? Results.Ok(wallet) : Results.NotFound();
            });
        }
    }
}
