## reproduce
This repo is an example to trigger an .NET MAUI bug as following:

1. build and debug the project for windows
2. click the "Add Item" button
3. an exception of `{"Value does not fall within the expected range."}	System.Exception {System.ArgumentException}`

note: android works fine without this issue

## trigger
it seems following combintions triggers the bug:
- CollectioView with SwipeView
- the binding list of collectionview is initiazed with some items
- then clear the list, and add a new item
