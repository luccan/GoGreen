$sqlScriptPath = $PSScriptRoot  + "\InitializeDB.sql"
sqlcmd -S "(localdb)\MSSQLLocalDB" -i $sqlScriptPath
$exeFolderPath = $PSScriptRoot  + "\publish\"
$exeName = "GoGreen.exe"
cd $exeFolderPath
Start-Process $exeName
Start-Process "chrome.exe" "http://localhost:5000"