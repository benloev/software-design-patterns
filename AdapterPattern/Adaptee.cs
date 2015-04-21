
namespace AdapterPattern
{
    /// <summary>
  /// The 'Adaptee' class
    /// defines an existing interface that needs adapting.
  /// </summary>
  class Adaptee
  {
    // The databank 'legacy API'
    public float GetStockPrice(string stock)
    {
        switch (stock)
        {
          case "GOOG": return 500.5f;
          case "MSFT": return 40.2f;
          case "AAPL": return 100.1f;
          default: return 0f;
        }
    }
    public string GetStockName(string stock)
    {
        switch (stock)
        {
            case "GOOG": return "Google Inc";
            case "MSFT": return "Microsoft Corporation";
            case "AAPL": return "Apple Inc.";
            default: return "";
        }
    }
  }
}
