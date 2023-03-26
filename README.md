# Categorize Trades

Application for categorize trades in different risks types

## Adding a new risk type

Follow the steps bellow to add a new risk type:<br>

1. Add a new risk type in **ERisk.cs**;
2. If there is a new property to be considered in the analysis, add it in the **ITrade.cs** also put this property in the last position of each line of the archive **tradesInput.txt**;
3. Implement this new property in all classes that implements **ITrade.cs** and of course implement a new class with the name of the new classification of the risk;
4. Create the logic for process this new property added in **CreateObject** method of **TradeFactory.cs**; 
4. Run the application.

### Example
You can seee an exemple how add a new risk type in the branch: **feature/adding-new-risk**<br>
For a best preview, you can create a pull-request for the see what werer added.
