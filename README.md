# mukavemet

## What is this?

This is a modern looking **task specific** HMI/SCADA like application written in C# and Winforms framework.

I created this for the company I work as an interface for an endurance measurement device we upgraded using an S7 PLC system. It uses [s7netplus](https://github.com/S7NetPlus/s7netplus)
library to connect and communicate with the PLC and SQLite for storing measurement data. It uses [Live-Charts](https://github.com/Live-Charts/Live-Charts) for visualising mesaurement results for now. It looks nice but the library seems like abandoned and has a lot of unsolved issues, so I'm planning switching to the built-in Chart control of winforms instead in newer versions.

## License

The code is licensed under GPLv3 except the images which contains logo of the company which then is a trademark of the company.
You are free to use the code, to tweak it for your own needs and to use it as an example for similar projects as long as you respect the license.
