# GoGreen
Go Green
<h1>Build Notes</h1>

    Required Specs:
        * SQL Server 2016 (for localdb) with instance name (localdb)\MSSQLLocalDB
        * Windows OS x64
        * Google Chrome

    Deployment:
        * Unzip files
        * Run deployRelease.ps1 in admin mode.

    GET Methods:
        * http://localhost:5000/Vegetable/Index?isApi=True
        * http://localhost:5000/Vegetable/Index?id=1&search=isApi=True
        * http://localhost:5000/Vegetable/Index?id=&search=carr&isApi=True
        * http://localhost:5000/Vegetable/Details?id=1&isApi=True

    POST Methods:
        * http://localhost:5000/Vegetable/Create?isApi=True (Expecting Name, Price in request Body)
        * http://localhost:5000/Vegetable/Edit?isApi=True (Expecting Id, Name, Price in request Body)
        * http://localhost:5000/Vegetable/Delete?isApi=True (Expecting Id in request Body)
