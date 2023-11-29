var const DEFAULT_BREWERY_NAME="Hipster Brew Co."

public void CreateMicroBrewery(string breweryName = null)
{
    var brewery = !string.IsNullOrEmpty(breweryName) ? breweryName : DEFAULT_BREWERY_NAME;
    // ...
}