echo "-------------------------------------------------------------"
echo "-                         Run CLI Tests                     -"
echo "-------------------------------------------------------------"

cd /home/runner/work/gingertest/Ginger/GingerRuntime#/bin/Release/net6.0/publish/
pwd
ls -alt

echo "******************************************************************************************************************************"
echo "help run"
echo "******************************************************************************************************************************"

dotnet GingerConsole.dll help run


echo "******************************************************************************************************************************"
echo "run simple solution"
echo "******************************************************************************************************************************"

dotnet GingerConsole.dll run -s "/home/runner/work/gingertest/gingertest/GingerCoreNETUnitTest/TestResources/Solutions/CLI" -e "Default" -r "Default Run Set"


echo "******************************************************************************************************************************"
echo "analyze solution"
echo "******************************************************************************************************************************"

dotnet GingerConsole.dll analyze -s "/home/runner/work/gingertest/gingertest/GingerCoreNETUnitTest/TestResources/Solutions/CLI" 
home/vsts/work/1/s/Ginger/GingerCoreNETUnitTest/TestResources/Solutions/CLI

# exit $exitcode
