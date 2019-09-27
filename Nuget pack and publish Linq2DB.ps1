cls

cd $PSScriptRoot
[System.IO.Directory]::SetCurrentDirectory($PSScriptRoot)

$currentDirectory = [System.IO.DirectoryInfo]::new([System.IO.Directory]::GetCurrentDirectory())

# run gitversion, get the string output
$str = GitVersion.exe | out-string
# convert the result to a JSON object
$json = ConvertFrom-Json $str
# get the appropriate version string (we need the nuget one)
$version = $json.NuGetVersionV2
echo $version

$currentDirectory = [System.IO.DirectoryInfo]::new([System.IO.Directory]::GetCurrentDirectory())

$slnFileName = "linq2db.ci.build.sln"
$configuration = "Debug"

# build the solution
[System.Console]::WriteLine("Building " + $slnFileName)
cmd.exe /c echo "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\msbuild.exe" $slnFileName /p:Version=$version -target:Rebuild /p:Configuration=$configuration -v:quiet
& "C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\Bin\msbuild.exe" $slnFileName /p:Version=$version -target:Rebuild /p:Configuration=$configuration -v:quiet

$outputDirectory = [System.IO.DirectoryInfo]::new("BuiltPackages")

if ($outputDirectory.Exists) {
    $outputDirectory.Delete($true)
}

# if the status of directory has changed since we created the DirectoryInfo, the information will be wrong, hence we need a new instance
$outputDirectory = [System.IO.DirectoryInfo]::new("BuiltPackages")

if (-Not $outputDirectory.Exists) {
    $outputDirectory.Create()
}

nuget.exe pack Nuget\linq2db.nuspec -OutputDirectory $outputDirectory.FullName -Version $version -Properties id=linq2db.legacy.sqlce -Properties Configuration=$configuration

$files = $outputDirectory.GetFiles("*.nupkg")

foreach ($file in $files) {
    nuget.exe add $file.FullName -source C:\FileNugetPackageSource
}