# Winotify

Winotify is a DLL files for .NET programs. Winotify is an Windows Alert that show to the corner of the desktop


## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them

```
.Net Framework 4.5 above
```

### Installing

Open your Project.
```
Project -> Add Reference -> Browse -> Locate Winotify.dll
```

if you locate the Winotify.dll

```
Check Winotify.dll -> Ok
```
### Video on how to use and import Winotify.dll



### How to use and Import

Importing Winotify.dll

```
Imports Winotify.Winotify
```
Above your Public Class Form1

```vbnet


 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AlertShow("The Quick Brown Fox jump over the lazy dog!", AlertType.Warning)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AlertShow("The Quick Brown Fox jump over the lazy dog!", AlertType.Info)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AlertShow("The Quick Brown Fox jump over the lazy dog!", AlertType.Errors)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AlertShow("The Quick Brown Fox jump over the lazy dog!", AlertType.Success)
    End Sub
```



## Built With

* Vb.Net

## Versioning

Release History

```
	1. Version 1.0.0
		* First Release Version
```

## Authors

* **MarJose Darang** - *Programmer* - [Whoami213](https://github.com/whoami213)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

<!-- ## Acknowledgments

* Hat tip to anyone who's code was used
* Inspiration
* etc -->

