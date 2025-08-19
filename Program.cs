using oneNFT.Services;
using oneNFT.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddSingleton<BlockchainService>();
builder.Services.AddSingleton<WalletService>();
builder.Services.AddSingleton<NftService>();
builder.Services.AddSingleton<StorageService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

WalletController.Map(app);
TransactionController.Map(app);
ChainController.Map(app);
NftController.Map(app);

app.Run();