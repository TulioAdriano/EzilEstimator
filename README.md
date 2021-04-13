# EzilEstimator
Displays statistics from Ezil.me.

# Configuration
### Wallet
Configuration screen will require entering an ETH and ZIL wallet to be able to retrieve information from Ezil.me.

### CoinMarketCap Api Key
Obsolete for now. It's no longer required to retrieve price of the cryptocurrencies. Currently using Minerstat API which doesn't require an API key.

### Machines
Enter a hostname to retrieve T-Rex statistics. If running on the same machine you can use localhost or 127.0.0.1. If running remote, make sure to add the --api-bind-http parameter to enable remote access.

# Usage
Once machines and wallet information are configured, the application will fetch all data on startup. The hashrate graph will plot for the first machine in the list. 

Use the buttons near the graph to combine all of them into a total hash power graph or overlay all workers. The up/down number above the merge graph buttons can be used to change the granularity of the data aggregation in case there are gaps between different workers. T-Rex samples every 10 seconds by default, so the application starts up with that value. Changing it to less than T-Rex's sampling interval will result in an inaccurate graph.

# TODO
* Add ZIL network stats
* Move all API calls to run on tasks 
* Make adjustments to auto detect zoom level based on DPI
* Add release notes

# License
MIT License. 

# Disclaimer
This source code is provided AS IS. Use it at your own risk. 
