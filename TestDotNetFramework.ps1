Write-Host "-------------------------------------------------------------"
Write-Host "-          Starting test for .Net Framework DLLs            -"
Write-Host "-------------------------------------------------------------"

cd "C:\Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\Extensions\TestPlatform\" 

$exitcode=0

mkdir D:\a\gingertest\gingertest\TestResults\DotNetFramework
mkdir D:\a\1\a\


Write-Host "-------------------------------------------------------------"
Write-Host "-                    print                 -"
Write-Host "-------------------------------------------------------------"
dir D:\a\gingertest\gingertest\Ginger\GingerCoreTest\bin\Release\

./vstest.console.exe "D:\a\gingertest\gingertest\Ginger\GingerCoreTest\bin\Release\net6.0\GingerCoreTest.dll" /Logger:trx /ResultsDirectory:D:\a\gingertest\gingertest\TestResults\DotNetFramework
Write-Host ">>>>>>>>>>>>>>>>>>>>>>>>>>>>> LastExitCode: " $LastExitCode
if ($LastExitCode -ne 0)
{
	$exitcode = 1
}


Write-Host "-------------------------------------------------------------"
Write-Host "-                    print                 -"
Write-Host "-------------------------------------------------------------"
dir D:\a\gingertest\gingertest\Ginger\GingerCoreTest\bin\Release\net6.0

./vstest.console.exe "D:\a\gingertest\gingertest\Ginger\GingerTest\bin\Release\net6.0\GingerTest.dll" /Logger:trx /ResultsDirectory:D:\a\gingertest\gingertest\TestResults\DotNetFramework
Write-Host ">>>>>>>>>>>>>>>>>>>>>>>>>>>>> LastExitCode: " $LastExitCode
if ($LastExitCode -ne 0)
{
	$exitcode = 1
}

Write-Host "-------------------------------------------------------------"
Write-Host "-                        Tests Completed                    -"
Write-Host "-------------------------------------------------------------"
cd D:\a\gingertest\gingertest\TestResults
dir


Write-Host "-------------------------------------------------------------"
Write-Host "-                    print                 -"
Write-Host "-------------------------------------------------------------"
dir D:\a\1\


Write-Host "-------------------------------------------------------------"
Write-Host "-                    Copy Test Artifacts                    -"
Write-Host "-------------------------------------------------------------"
New-Item -Path "D:\a\1\a" -Name "TestCompleted.txt" -ItemType "file" -Value "Test Completed Artifacts"

Write-Host "-------------------------------------------------------------"
Write-Host "-                    print  path     1          -"
Write-Host "-------------------------------------------------------------"
D:\a\gingertest\gingertest\Ginger\GingerUtilsTest
Write-Host "-------------------------------------------------------------"
Write-Host "-                    print  path     2          -"
Write-Host "-------------------------------------------------------------"
D:\a\gingertest\gingertest\Ginger\GingerUtilsTest\bin
Write-Host "-------------------------------------------------------------"
Write-Host "-                    print  path     3          -"
Write-Host "-------------------------------------------------------------"
D:\a\gingertest\gingertest\Ginger\GingerUtilsTest\bin\Release
Write-Host "-------------------------------------------------------------"
Write-Host "-                    print  path     4          -"
Write-Host "-------------------------------------------------------------"
D:\a\gingertest\gingertest\Ginger\GingerUtilsTest\bin\Release\net6.0\


Compress-Archive -Path 'D:\a\gingertest\gingertest\Ginger\GingerUtilsTest\bin\Release\net6.0\TestArtifacts' -DestinationPath 'D:\a\1\a\GingerUtilsTestArtifacts'
Compress-Archive -Path 'D:\a\gingertest\gingertest\Ginger\GingerCoreCommonTest\bin\Release\net6.0\TestArtifacts' -DestinationPath 'D:\a\1\a\GingerCoreCommonTestArtifacts'
Compress-Archive -Path 'D:\a\gingertest\gingertest\Ginger\GingerCoreNETUnitTest\bin\Release\net6.0\TestArtifacts' -DestinationPath 'D:\a\1\a\GingerCoreNETUnitTestArtifacts'
Compress-Archive -Path 'D:\a\gingertest\gingertest\Ginger\GingerConsoleTest\bin\Release\net6.0\TestArtifacts' -DestinationPath 'D:\a\1\a\GingerConsoleTestArtifacts'
Compress-Archive -Path 'D:\a\gingertest\gingertest\GingerAutoPilotTest\bin\Release\net6.0\TestArtifacts' -DestinationPath 'D:\a\1\a\GingerAutoPilotTestArtifacts'
# Compress-Archive -Path 'd:\a\1\s\Ginger\GingerPluginCoreTest\bin\Release\netcoreapp3.1\TestArtifacts' -DestinationPath 'D:\a\1\a\GingerPluginCoreTestArtifacts'
      
# Compress-Archive -Path 'd:\a\1\s\Ginger\GingerCoreTest\bin\Release\netcoreapp3.1\TestArtifacts' -DestinationPath 'D:\a\1\a\GingerCoreTestTestArtifacts'
# Compress-Archive -Path 'd:\a\1\s\Ginger\GingerTest\bin\Release\netcoreapp3.1\TestArtifacts' -DestinationPath 'D:\a\1\a\GingerTestArtifacts'

Write-Host "-------------------------------------------------------------"
Write-Host "-                         Artifacts List                    -"
Write-Host "-------------------------------------------------------------"
cd D:\a\1\a\
dir


exit $exitcode
