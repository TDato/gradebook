REM walk through subdirectories delete generated subdirectories

for /d %%D in (*) do (
	echo %%~fD
	cd %%~D
	CleanMe.bat
	cd ..
)