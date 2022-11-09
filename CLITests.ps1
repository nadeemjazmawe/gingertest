Write-Host "-------------------------------------------------------------"
Write-Host "-                         Run CLI Tests                     -"
Write-Host "-------------------------------------------------------------"

cd /home/runner/work/gingertest/gingertest/GingerRuntime/bin/Release/net6.0/publish/


Write-Host "******************************************************************************************************************************"
Write-Host "help run"
Write-Host "******************************************************************************************************************************"

dotnet GingerConsole.dll help run


Write-Host "******************************************************************************************************************************"
Write-Host "run simple solution"
Write-Host "******************************************************************************************************************************"

dotnet GingerConsole.dll run -s "/home/runner/work/gingertest/gingertest/GingerCoreNETUnitTest/TestResources/Solutions/CLI" -e "Default" -r "Default Run Set"


Write-Host "******************************************************************************************************************************"
Write-Host "analyze solution"
Write-Host "******************************************************************************************************************************"

dotnet GingerConsole.dll analyze -s "/home/runner/work/gingertest/gingertest/GingerCoreNETUnitTest/TestResources/Solutions/CLI" 


exit $exitcode
