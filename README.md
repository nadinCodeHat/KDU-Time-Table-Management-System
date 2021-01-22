# KDU-Time-Table-Management-System
To prepare the timetable and manage its manual system, allocate lectures and send notifications by simplifying the process resource allocation.

## Tools Used
- Visual Studio 2019
- Microsoft SQL Server 2019 Developer Edition
- Guna Framework


## Installing Guna Framework
1. Open Visual Studio
2. Open Toolbox and "Right-Click" and "Choose Items"
3. Inside ".NET Framework Components" go to "Browse" and locate the "Guna.UI2.dll" file
    "_Getintopc.com_Guna_UI_Framework_Ultimate_v2.0.0.1\Guna_UI_Framework_Ultimate_v2.0.0.1\Guna.UI-Framework-Lib-master\Guna.UI2 WinForms\.net 4.0"
4. Next open "Keygen.exe" in "_Getintopc.com_Guna_UI_Framework_Ultimate_v2.0.0.1\Guna_UI_Framework_Ultimate_v2.0.0.1\GunaUIKeygen"
5. To check if it is activated
6. Go to "_Getintopc.com_Guna_UI_Framework_Ultimate_v2.0.0.1\Guna_UI_Framework_Ultimate_v2.0.0.1\Guna.UI-Framework-Lib-master\Guna UI Activation\Guna UI Activation\bin\Debug"
7. Click on "Guna UI Activation.exe"
8. You will see a window "Your license is activated"
9. Guna framework is activated and now you can open and run the application

Check out the guna installation tutorial [Download and install Guna UI .Net Framework latest [2020]](https://www.youtube.com/watch?v=Rx40_T_yPZ0&t=130s)


## Additional Information
- Connection String to SQL Server is stored in the App.config file
- System.Configuration library is needed ( Add Reference -> Framework -> System.Configuration
    
```xml
<connectionStrings>
        <add name="con_string"
        connectionString="Data Source=DESKTOP-T132NFE;Initial Catalog=ttmsdb;Integrated Security=True;"
        providerName="System.Data.SqlClient"/>
</connectionStrings>
```

```c#
//Connection String
string con_string = ConfigurationManager.ConnectionStrings["con_string"].ConnectionString;
```
