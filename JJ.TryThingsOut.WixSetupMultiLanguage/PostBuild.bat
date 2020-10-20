rem Current directory is meant to be Visual Studio's ProjectDir variable.
rem echo set ProjectDir=%CD%
rem set ProjectDir=%CD%

rem First parameter may be Visual Studio's OutDir variable, a relative path like "bin\Debug\".
echo "set OutDir=%1
set OutDir=%1

rem (Giving project files the properties Build Action = Content and Copy to Output Directory = Always did not seem copy them to the bin (sub-)folder.)
echo "copy CreateEmbedLangTransform.cmd %OutDir%"
copy CreateEmbedLangTransform.cmd %OutDir%

echo "copy CreateLocalizedInstallerAllLanguages.cmd %OutDir%"
copy CreateLocalizedInstallerAllLanguages.cmd %OutDir%

echo "copy MsiTran.exe %OutDir%"
copy MsiTran.exe %OutDir%

echo "copy wilangid.vbs %OutDir%"
copy wilangid.vbs %OutDir%

echo "copy wisubstg.vbs %OutDir%"
copy wisubstg.vbs %OutDir%

echo "cd %OutDir%"
cd %OutDir%

echo "call CreateLocalizedInstallerAllLanguages.cmd"
call CreateLocalizedInstallerAllLanguages.cmd