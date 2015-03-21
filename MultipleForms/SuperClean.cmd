@echo off
echo A cleaning script for .NET MSBuild compiled folders - Jason Chalom 2015
echo This will delete all bin and obj folders
echo Beware!!
echo
echo First MSBUILD CLEAN will be activated.
echo Will use the location for VS 2013 MS Build Tools 32 bit X86
pause
"C:\Program Files (x86)\MSBuild\12.0\Bin\msbuild.exe" /t:clean
echo not implemented yet
echo This will remove all bin and obj folders found
pause
for /d /r . %%d in (bin,obj) do @if exist "%%d" rd /s/q "%%d"
