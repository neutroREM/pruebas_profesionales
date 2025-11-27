namespace certinom_sadper_v1.Data.Factories
{
    public interface IMongoDBContextFactory
    {
        cls_MongoDBContext GetContext();
        bool IsInitialized { get; }
        Task<bool> InitializeAsync(string sRFC); 
    }
}
